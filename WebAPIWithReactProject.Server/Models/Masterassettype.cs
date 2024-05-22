using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class Masterassettype
{
    public int Assettypeid { get; set; }

    public string Code { get; set; } = null!;

    public string? Details { get; set; }
}
