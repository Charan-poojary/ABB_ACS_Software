using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class VillageMaster
{
    public int SrNo { get; set; }

    public string? Villagename { get; set; }

    public string? Details { get; set; }

    public string? Flag { get; set; }

    public string? Stateid { get; set; }

    public string? Districtid { get; set; }

    public string? Usedflag { get; set; }

    public string? Section { get; set; }
}
