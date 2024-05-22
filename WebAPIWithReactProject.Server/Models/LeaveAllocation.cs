using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class LeaveAllocation
{
    public int SrNo { get; set; }

    public int? Empid { get; set; }

    public string? LeaveCode { get; set; }

    public int? NoOfdays { get; set; }

    public string? Notes { get; set; }

    public int? Balance { get; set; }

    public string? Description { get; set; }

    public string? Periods { get; set; }

    public string? Actions { get; set; }
}
