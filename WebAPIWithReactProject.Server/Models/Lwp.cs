using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class Lwp
{
    public int Srno { get; set; }

    public int? Empid { get; set; }

    public string? Type { get; set; }

    public string? Notes { get; set; }

    public DateTime? Fromdate { get; set; }

    public DateTime? Todate { get; set; }

    public string? Status { get; set; }

    public string? Flag { get; set; }

    public DateTime? Requestdate { get; set; }

    public string? Remark { get; set; }

    public string? ApprovedBy { get; set; }

    public DateTime? ApproveDate { get; set; }

    public string? ToApprove { get; set; }

    public string? IsNotify { get; set; }

    public string? Approvers { get; set; }

    public string? Smstext { get; set; }
}
