using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class Camset
{
    public int Srno { get; set; }

    public string? Camname { get; set; }

    public string? Camip { get; set; }

    public string? Details { get; set; }

    public string? Camport { get; set; }

    public string? Camuser { get; set; }

    public string? Campass { get; set; }
}
