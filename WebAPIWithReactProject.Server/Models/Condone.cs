using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class Condone
{
    public int Srno { get; set; }

    public int? Days { get; set; }

    public int? Mons { get; set; }

    public int? Years { get; set; }

    public string? Dates { get; set; }

    public string? Condonetype { get; set; }

    public string? Condonehrs { get; set; }

    public string? Notes { get; set; }

    public int? Empid { get; set; }

    public string? Flag { get; set; }

    public DateTime? Compoffdate { get; set; }
}
