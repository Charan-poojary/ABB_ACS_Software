using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class Weekmaster
{
    public int Srno { get; set; }

    public int? Weekno { get; set; }

    public DateTime? Fromdate { get; set; }

    public string? Details { get; set; }

    public string? Wnotes { get; set; }

    public string? Wnotes1 { get; set; }

    public string? Wnotes2 { get; set; }
}
