using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class AttGraph
{
    public int Srno { get; set; }

    public int? Userid { get; set; }

    public int? Graphid { get; set; }

    public int? Slot { get; set; }

    public string? Details { get; set; }
}
