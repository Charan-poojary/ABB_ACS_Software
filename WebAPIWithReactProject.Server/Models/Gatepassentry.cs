using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class Gatepassentry
{
    public int Srno { get; set; }

    public int? Requestid { get; set; }

    public string? Empid { get; set; }

    public DateTime? Dates { get; set; }

    public string? Fromtime { get; set; }

    public string? Totime { get; set; }

    public string? Details { get; set; }

    public string? Status { get; set; }

    public string? Notes { get; set; }

    public DateTime? Requestdate { get; set; }

    public string? ApprovedBy { get; set; }

    public DateTime? ApproveDate { get; set; }

    public string? ToApprove { get; set; }

    public string? IsNotify { get; set; }

    public string? Approvers { get; set; }

    public string? Smstext { get; set; }
}
