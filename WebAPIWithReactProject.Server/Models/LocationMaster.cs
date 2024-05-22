using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class LocationMaster
{
    public int Srno { get; set; }

    public string? Compid { get; set; }

    public string? Locationid { get; set; }

    public string? Details { get; set; }

    public string? Flag { get; set; }

    public string? Usedflag { get; set; }

    public string? LocStatus { get; set; }
}
