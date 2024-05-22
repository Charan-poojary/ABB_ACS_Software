using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class Projectmaster
{
    public int Srno { get; set; }

    public string? Idcno { get; set; }

    public string? Projectno { get; set; }

    public int? Projectmgr { get; set; }

    public string? Details { get; set; }

    public string? Pmnotes { get; set; }

    public string? Pmnotes1 { get; set; }

    public string? Pmnotes2 { get; set; }
}
