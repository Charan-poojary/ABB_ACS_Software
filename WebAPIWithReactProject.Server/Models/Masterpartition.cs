using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class Masterpartition
{
    public int Srno { get; set; }

    public byte? Id { get; set; }

    public int? Cid { get; set; }

    public byte? Enable { get; set; }

    public string? Name { get; set; }

    public string? Account { get; set; }

    public byte? Entrydelay1 { get; set; }

    public byte? Entrydelay2 { get; set; }

    public byte? Exitdelay1 { get; set; }

    public byte? Exitdelay2 { get; set; }

    public byte? Sirentime { get; set; }

    public byte? Alarmcount { get; set; }

    public byte? Partoption { get; set; }
}
