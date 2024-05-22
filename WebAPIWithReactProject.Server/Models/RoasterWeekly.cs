using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class RoasterWeekly
{
    public int Srno { get; set; }

    public string? Patternname { get; set; }

    public int? Weekcount { get; set; }

    public int? Weekno { get; set; }

    public string? Sun { get; set; }

    public string? Mon { get; set; }

    public string? Tue { get; set; }

    public string? Wed { get; set; }

    public string? Thu { get; set; }

    public string? Fri { get; set; }

    public string? Sat { get; set; }

    public string? Compid { get; set; }

    public string? Locationid { get; set; }
}
