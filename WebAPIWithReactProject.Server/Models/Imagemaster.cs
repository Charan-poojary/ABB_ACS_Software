using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class Imagemaster
{
    public int Srno { get; set; }

    public int Visitorid { get; set; }

    public byte[] Image { get; set; } = null!;

    public string? Flag { get; set; }
}
