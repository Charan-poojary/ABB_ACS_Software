using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class Scandoc
{
    public int Srno { get; set; }

    public int? Visitorid { get; set; }

    public string? Docname { get; set; }

    public byte[]? Docimage { get; set; }

    public string? Flag { get; set; }
}
