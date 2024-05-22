using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class Leavesanctioned
{
    public int Srno { get; set; }

    public int? EmpId { get; set; }

    public DateTime? Dates { get; set; }

    public string? Type { get; set; }

    public string? Leavecode { get; set; }

    public string? Status { get; set; }

    public int? Days { get; set; }

    public int? Months { get; set; }

    public int? Years { get; set; }
}
