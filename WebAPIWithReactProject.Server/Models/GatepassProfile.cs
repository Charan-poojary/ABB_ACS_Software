using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class GatepassProfile
{
    public int Srno { get; set; }

    public string? Profilefor { get; set; }

    public string? Profile { get; set; }

    public string? Floorwise { get; set; }

    public string? Floor { get; set; }

    public int? Hostid { get; set; }

    public string? Compid { get; set; }

    public string? Locationid { get; set; }
}
