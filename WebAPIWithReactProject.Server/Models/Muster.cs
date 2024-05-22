using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class Muster
{
    public int? Srno { get; set; }

    public DateTime? Activefrom { get; set; }

    public DateTime? Activeto { get; set; }

    public DateTime? Activefromdate { get; set; }

    public DateTime? Activetodate { get; set; }

    public string? Active { get; set; }

    public string? Musternotes { get; set; }

    public string? Musternote1 { get; set; }

    public string? Musternote2 { get; set; }
}
