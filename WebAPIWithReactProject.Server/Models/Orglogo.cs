using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class Orglogo
{
    public int Srno { get; set; }

    public byte[]? Logo { get; set; }

    public string? Details { get; set; }

    public string? Notes { get; set; }
}
