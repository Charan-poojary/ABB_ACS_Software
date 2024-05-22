using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class DistrictMaster
{
    public int Srno { get; set; }

    public string? Stateid { get; set; }

    public string? Districtname { get; set; }

    public string? Details { get; set; }

    public string? Flag { get; set; }

    public string? Usedflag { get; set; }
}
