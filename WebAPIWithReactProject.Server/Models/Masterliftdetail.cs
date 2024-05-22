using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class Masterliftdetail
{
    public int Floorid { get; set; }

    public int? Liftid { get; set; }

    public string? Floorname { get; set; }

    public int? Cid { get; set; }

    public int? Ifid { get; set; }

    public int? Relay { get; set; }

    public string? Notes { get; set; }

    public string? Notes1 { get; set; }

    public string? Notes2 { get; set; }
}
