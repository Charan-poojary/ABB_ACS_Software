using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class Carddatum
{
    public int Srno { get; set; }

    public string? Cardno { get; set; }

    public string? Facilitycode { get; set; }

    public decimal? Uniqueid { get; set; }

    public string? Nofmt { get; set; }

    public string? Accessgroups { get; set; }

    public string? Status { get; set; }

    public int? Accesstype { get; set; }
}
