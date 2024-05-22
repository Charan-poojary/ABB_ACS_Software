using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class RoasterMaster
{
    public int Srno { get; set; }

    public string? Patterncode { get; set; }

    public string? Patternname { get; set; }

    public string? Type { get; set; }

    public string? Wkoffon1 { get; set; }

    public string? Wkoffon2 { get; set; }

    public string? Wkoff1 { get; set; }

    public string? Wkoff2 { get; set; }

    public string? Changeon { get; set; }

    public string? Monthlychangedate { get; set; }

    public string? Compid { get; set; }

    public string? Locationid { get; set; }

    public int? Usedflag { get; set; }
}
