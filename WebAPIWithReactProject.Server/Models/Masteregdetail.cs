using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class Masteregdetail
{
    public int Srno { get; set; }

    public int? Egid { get; set; }

    public int? Floorid { get; set; }

    public string? Details { get; set; }

    public string? Notes { get; set; }

    public int? Liftid { get; set; }
}
