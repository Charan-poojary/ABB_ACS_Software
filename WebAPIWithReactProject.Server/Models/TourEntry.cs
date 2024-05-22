using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class TourEntry
{
    public int Srno { get; set; }

    public int? Requestid { get; set; }

    public int? Empid { get; set; }

    public int? Days { get; set; }

    public int? Mons { get; set; }

    public int? Years { get; set; }

    public string? Modes { get; set; }

    public string? Flag { get; set; }

    public string? Notes { get; set; }

    public DateTime? Dates { get; set; }

    public string? Workhrs { get; set; }

    public DateTime? Compoffdate { get; set; }

    public string? Place { get; set; }

    public string? Remark { get; set; }

    public string? ApprovedBy { get; set; }

    public DateTime? ApproveDate { get; set; }

    public string? ToApprove { get; set; }

    public string? IsNotify { get; set; }

    public string? Approvers { get; set; }

    public string? Smstext { get; set; }
}
