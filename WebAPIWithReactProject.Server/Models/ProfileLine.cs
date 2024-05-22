using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class ProfileLine
{
    public int Srno { get; set; }

    public string? Profilename { get; set; }

    public int? X1 { get; set; }

    public int? Y1 { get; set; }

    public int? X2 { get; set; }

    public int? Y2 { get; set; }

    public string? Color { get; set; }

    public string? Thickness { get; set; }

    public string? Details { get; set; }
}
