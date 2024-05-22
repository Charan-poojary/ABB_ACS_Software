using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class Cardmaster
{
    public int Srno { get; set; }

    public string? Cardno { get; set; }

    public string? Floorno { get; set; }

    public string? Flag { get; set; }

    public int? Status { get; set; }

    public int? Gatepassno { get; set; }

    public int? Gateno { get; set; }
}
