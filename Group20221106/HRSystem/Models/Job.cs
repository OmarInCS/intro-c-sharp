using System;
using System.Collections.Generic;

namespace HRSystem.Models;

public partial class Job
{
    public long JobId { get; set; }

    public string JobTitle { get; set; } = null!;

    public double MinSalary { get; set; }

    public double MaxSalary { get; set; }

    public virtual ICollection<Employee> Employees { get; } = new List<Employee>();
}
