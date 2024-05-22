using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class DescMaster
{
    public int SrNo { get; set; }

    public string? Designation { get; set; }

    public string? Details { get; set; }

    public string? Compid { get; set; }

    public string? Flag { get; set; }

    public string? Locationid { get; set; }

    public string? Usedflag { get; set; }

    public string? Section { get; set; }
}
