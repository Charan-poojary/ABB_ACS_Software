using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class Leaverequest
{
    public int Srno { get; set; }

    public int? EmpId { get; set; }

    public DateTime? Dates { get; set; }

    public string? Type { get; set; }

    public string? Leavecode { get; set; }

    public string? Status { get; set; }

    public int? Days { get; set; }

    public int? Months { get; set; }

    public int? Years { get; set; }

    public string? Noofdays { get; set; }

    public string? Sections { get; set; }

    public int? Requestid { get; set; }

    public string? Flags { get; set; }

    public string? Leavereason { get; set; }

    public string? ToApprove { get; set; }

    public string? IsNotify { get; set; }

    public string? Approvers { get; set; }
}
