using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class Fpmaster
{
    public int Srno { get; set; }

    public int? Visitorid { get; set; }

    public byte[]? Fp { get; set; }

    public string? Flag { get; set; }

    public byte[]? Fpimg { get; set; }

    public string? Tmpsize { get; set; }
}
