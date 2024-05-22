using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class Tempimage
{
    public int Srno { get; set; }

    public string? Names { get; set; }

    public byte[] Image { get; set; } = null!;

    public string? Tmpsize { get; set; }
}
