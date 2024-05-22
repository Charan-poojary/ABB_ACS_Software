using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class Odrequestnew
{
    public int Srno { get; set; }

    public int? Requestid { get; set; }

    public DateTime? Dates { get; set; }

    public string? Odhrs { get; set; }

    public int? Empid { get; set; }

    public DateTime? Requestdate { get; set; }

    public string? Status { get; set; }

    public string? Oddetails { get; set; }

    public string? Odnotes { get; set; }

    public string? Odnotes1 { get; set; }

    public string? Place { get; set; }

    public string? Remark { get; set; }

    public string? ApprovedBy { get; set; }

    public DateTime? ApproveDate { get; set; }

    public string? ToApprove { get; set; }

    public string? IsNotify { get; set; }

    public string? Approvers { get; set; }

    public string? Smstext { get; set; }
}
