using System;
using System.Collections.Generic;

namespace HRSystem.Models;

public partial class Department
{
    public long DepartmentId { get; set; }

    public string DepartmentName { get; set; } = null!;

    public long LocationId { get; set; }

    public virtual ICollection<Employee> Employees { get; } = new List<Employee>();

    public virtual Location Location { get; set; } = null!;

    public override string ToString() {
        return DepartmentName;
    }
}
