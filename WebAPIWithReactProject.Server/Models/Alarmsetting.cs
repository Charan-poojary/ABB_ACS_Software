using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class Alarmsetting
{
    public int Srno { get; set; }

    public string? Alarmtype { get; set; }

    public string? Alarmtypedesc { get; set; }

    public string? Popup { get; set; }

    public int? Action { get; set; }

    public string? Flag { get; set; }

    public string? Showflag { get; set; }

    public string? Notes { get; set; }

    public string? Note1 { get; set; }

    public string? Note2 { get; set; }
}
