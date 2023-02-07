using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace HRSystem.Models;

public partial class HrContext : DbContext
{
    public HrContext()
    {
    }

    public HrContext(DbContextOptions<HrContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<Dependent> Dependents { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Job> Jobs { get; set; }

    public virtual DbSet<Location> Locations { get; set; }

    public virtual DbSet<Region> Regions { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlite("Data Source=D:\\hr.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Department>(entity =>
        {
            entity.ToTable("departments");

            entity.Property(e => e.DepartmentId).HasColumnName("department_id");
            entity.Property(e => e.DepartmentName).HasColumnName("department_name");
            entity.Property(e => e.LocationId).HasColumnName("location_id");

            entity.HasOne(d => d.Location).WithMany(p => p.Departments).HasForeignKey(d => d.LocationId);
        });

        modelBuilder.Entity<Dependent>(entity =>
        {
            entity.ToTable("dependents");

            entity.Property(e => e.DependentId).HasColumnName("dependent_id");
            entity.Property(e => e.EmployeeId).HasColumnName("employee_id");
            entity.Property(e => e.FirstName).HasColumnName("first_name");
            entity.Property(e => e.LastName).HasColumnName("last_name");
            entity.Property(e => e.Relationship).HasColumnName("relationship");

            entity.HasOne(d => d.Employee).WithMany(p => p.Dependents).HasForeignKey(d => d.EmployeeId);
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.ToTable("employees");

            entity.Property(e => e.EmployeeId).HasColumnName("employee_id");
            entity.Property(e => e.DepartmentId).HasColumnName("department_id");
            entity.Property(e => e.Email).HasColumnName("email");
            entity.Property(e => e.FirstName).HasColumnName("first_name");
            entity.Property(e => e.HireDate).HasColumnName("hire_date");
            entity.Property(e => e.JobId).HasColumnName("job_id");
            entity.Property(e => e.LastName).HasColumnName("last_name");
            entity.Property(e => e.ManagerId).HasColumnName("manager_id");
            entity.Property(e => e.PhoneNumber).HasColumnName("phone_number");
            entity.Property(e => e.Salary)
                .HasColumnType("double")
                .HasColumnName("salary");

            entity.HasOne(d => d.Department).WithMany(p => p.Employees).HasForeignKey(d => d.DepartmentId);

            entity.HasOne(d => d.Job).WithMany(p => p.Employees).HasForeignKey(d => d.JobId);

            entity.HasOne(d => d.Manager).WithMany(p => p.InverseManager)
                .HasForeignKey(d => d.ManagerId)
                .OnDelete(DeleteBehavior.Cascade);
        });

        modelBuilder.Entity<Job>(entity =>
        {
            entity.ToTable("jobs");

            entity.Property(e => e.JobId).HasColumnName("job_id");
            entity.Property(e => e.JobTitle).HasColumnName("job_title");
            entity.Property(e => e.MaxSalary)
                .HasColumnType("double")
                .HasColumnName("max_salary");
            entity.Property(e => e.MinSalary)
                .HasColumnType("double")
                .HasColumnName("min_salary");
        });

        modelBuilder.Entity<Location>(entity =>
        {
            entity.ToTable("locations");

            entity.Property(e => e.LocationId).HasColumnName("location_id");
            entity.Property(e => e.City).HasColumnName("city");
            entity.Property(e => e.CountryId).HasColumnName("country_id");
            entity.Property(e => e.PostalCode).HasColumnName("postal_code");
            entity.Property(e => e.StateProvince).HasColumnName("state_province");
            entity.Property(e => e.StreetAddress).HasColumnName("street_address");
        });

        modelBuilder.Entity<Region>(entity =>
        {
            entity.ToTable("regions");

            entity.Property(e => e.RegionId).HasColumnName("region_id");
            entity.Property(e => e.RegionName).HasColumnName("region_name");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
