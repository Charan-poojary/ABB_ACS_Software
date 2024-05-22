using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class LeaveMaster
{
    public int Srno { get; set; }

    public int? Empid { get; set; }

    public string? Financeyear { get; set; }

    public string? Leavecode { get; set; }

    public double? Allocated { get; set; }

    public double? Used { get; set; }

    public double? Balance { get; set; }

    public string? Flag { get; set; }

    public string? Locationid { get; set; }

    public double? Accudays { get; set; }

    public string? Opflag { get; set; }

    public double? Opbal { get; set; }

    public string? Catname { get; set; }
}
