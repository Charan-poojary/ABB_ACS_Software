using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class LeaveAccumulation
{
    public int Srno { get; set; }

    public string? Financeyear { get; set; }

    public double? AccAllowed { get; set; }

    public double? LeaveTransferred { get; set; }

    public string? Leavecode { get; set; }

    public string? Catname { get; set; }

    public string? Empid { get; set; }
}
