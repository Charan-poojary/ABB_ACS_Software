using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class ComOffrequest
{
    public int Srno { get; set; }

    public int Empid { get; set; }

    public DateTime DateWork { get; set; }

    public DateTime Datecomp { get; set; }

    public DateTime PunchTime { get; set; }

    public string? Details { get; set; }

    public string Flag { get; set; } = null!;

    public int Days { get; set; }

    public int Mons { get; set; }

    public int Yrs { get; set; }

    public int Hrs { get; set; }

    public int Mins { get; set; }

    public int Type { get; set; }

    public int? Requestid { get; set; }
}
