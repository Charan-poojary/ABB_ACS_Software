using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class LeaveRule
{
    public int Srno { get; set; }

    public string? Catname { get; set; }

    public string? Leavecode { get; set; }

    public string? Totaldays { get; set; }

    public string? Totaltime { get; set; }

    public string? Maxdays { get; set; }

    public string? Mindays { get; set; }

    public string? Accumulation { get; set; }

    public string? Accumulationdays { get; set; }

    public string? Encashment { get; set; }

    public string? Halfday { get; set; }

    public string? Negativebalance { get; set; }

    public string? Wkoffleave { get; set; }

    public string? Holidayleave { get; set; }

    public string? Flag { get; set; }

    public string? Notes { get; set; }

    public string? Compid { get; set; }

    public string? Locationid { get; set; }

    public string? Negativebal { get; set; }

    public string? Usedflag { get; set; }

    public string? Applyminpresent { get; set; }

    public decimal? Minpresent { get; set; }

    public string? Perdayflag { get; set; }

    public double? Perdayleave { get; set; }

    public string? Perdaylimit { get; set; }

    public string? Seriesleavecode { get; set; }
}
