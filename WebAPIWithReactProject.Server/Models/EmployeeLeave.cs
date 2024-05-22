using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class EmployeeLeave
{
    public int Srno { get; set; }

    public int? Empid { get; set; }

    public DateTime? Fromdate { get; set; }

    public DateTime? Todate { get; set; }

    public string? LeaveCode { get; set; }

    public string? Notes { get; set; }

    public decimal? Noofdays { get; set; }

    public string? Financeyear { get; set; }

    public DateTime? Applydate { get; set; }
}
