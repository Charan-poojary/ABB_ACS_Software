using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class HikIorule
{
    public int Ruleid { get; set; }

    public string? Rulename { get; set; }

    public int? Cid { get; set; }

    public int? Eventorcard { get; set; }

    public int? Inputsource { get; set; }

    public int? Majoreventid { get; set; }

    public int? Minoreventid { get; set; }

    public string? Cardno { get; set; }

    public string? Alarmout { get; set; }

    public string? Opendoor { get; set; }

    public string? Closedoor { get; set; }

    public string? Normalopen { get; set; }

    public string? Normalclose { get; set; }

    public int? Mainbuzzer { get; set; }

    public string? Readerbuzzer { get; set; }

    public string? Snapshot { get; set; }
}
