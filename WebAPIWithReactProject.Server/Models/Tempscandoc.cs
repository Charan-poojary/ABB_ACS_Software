using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class Tempscandoc
{
    public int Srno { get; set; }

    public string? Docname { get; set; }

    public byte[]? Docimage { get; set; }
}
