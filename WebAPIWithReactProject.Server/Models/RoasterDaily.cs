using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class RoasterDaily
{
    public int Srno { get; set; }

    public string? Patternname { get; set; }

    public string? Shiftname { get; set; }

    public int? Days { get; set; }

    public string? Compid { get; set; }

    public string? Locationid { get; set; }
}
