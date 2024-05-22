using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class TempapprovedOt
{
    public int Srno { get; set; }

    public int? Empid { get; set; }

    public int? Days { get; set; }

    public int? Mons { get; set; }

    public int? Yrs { get; set; }

    public string? Othrs { get; set; }

    public string? Flag { get; set; }

    public string? Punchtimes { get; set; }

    public int? Teamid { get; set; }

    public int? Lineid { get; set; }

    public string? Approveflag { get; set; }

    public DateTime? Dates { get; set; }
}
