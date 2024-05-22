using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class Timesheet
{
    public int Srno { get; set; }

    public int? Empid { get; set; }

    public DateTime? Dates { get; set; }

    public int? Weekno { get; set; }

    public int? Day { get; set; }

    public string? Hrs { get; set; }

    public int? Projectnameid { get; set; }

    public int? Activityid { get; set; }

    public string? Tsdetails { get; set; }

    public string? Tsnotes1 { get; set; }

    public string? Tsnotes2 { get; set; }

    public string? Tsnotes3 { get; set; }
}
