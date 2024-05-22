using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class Masterlift
{
    public int Liftid { get; set; }

    public string? Liftname { get; set; }

    public int? Cid { get; set; }

    public int? Rid { get; set; }

    public string? Notes { get; set; }

    public string? Notes1 { get; set; }

    public string? Notes2 { get; set; }
}
