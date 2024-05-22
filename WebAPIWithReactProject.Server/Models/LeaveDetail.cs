using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class LeaveDetail
{
    public int SrNo { get; set; }

    public int? EmpId { get; set; }

    public string? LeaveCode { get; set; }

    public string? Days { get; set; }

    public string? Mons { get; set; }

    public string? Years { get; set; }

    public string? Halfday { get; set; }

    public string? Section { get; set; }

    public DateTime? Dates { get; set; }

    public DateTime? Applydate { get; set; }
}
