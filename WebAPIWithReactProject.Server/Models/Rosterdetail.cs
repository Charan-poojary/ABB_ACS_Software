using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class Rosterdetail
{
    public int Srno { get; set; }

    public int? Rosterid { get; set; }

    public int? Days { get; set; }

    public string? Shift { get; set; }

    public string? Details { get; set; }

    public string? Note1 { get; set; }

    public string? Note2 { get; set; }
}
