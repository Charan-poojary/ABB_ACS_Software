using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class EmpShiftMaster
{
    public int Srno { get; set; }

    public string? Shiftid { get; set; }

    public DateTime? Dates { get; set; }

    public int? Empid { get; set; }

    public int? Days { get; set; }

    public int? Months { get; set; }

    public int? Years { get; set; }

    public string? Type { get; set; }

    public string? Contflag { get; set; }

    public DateTime? Todates { get; set; }
}
