using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class Lateearlypenalty
{
    public int Srno { get; set; }

    public string? Empid { get; set; }

    public string? Dedtype { get; set; }

    public DateTime? Dates { get; set; }

    public int? Mons { get; set; }

    public int? Years { get; set; }

    public int? Days { get; set; }

    public string? Dedcode { get; set; }

    public double? Dedcount { get; set; }

    public string? Daystatus { get; set; }

    public string? Flag { get; set; }
}
