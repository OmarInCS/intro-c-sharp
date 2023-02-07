using System;
using System.Collections.Generic;

namespace HRSystem.Models;

public partial class Location
{
    public long LocationId { get; set; }

    public string? StreetAddress { get; set; }

    public string? PostalCode { get; set; }

    public string City { get; set; } = null!;

    public string? StateProvince { get; set; }

    public long CountryId { get; set; }

    public virtual ICollection<Department> Departments { get; } = new List<Department>();

    public override string ToString() {
        return StreetAddress;
    }
}
