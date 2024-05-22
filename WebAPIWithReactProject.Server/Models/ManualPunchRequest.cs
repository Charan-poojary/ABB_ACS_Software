using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class ManualPunchRequest
{
    public int Srno { get; set; }

    public int Empid { get; set; }

    public DateTime Times { get; set; }

    public int Type { get; set; }

    public string Details { get; set; } = null!;

    public DateTime Dates { get; set; }

    public string Flag { get; set; } = null!;

    public int Days { get; set; }

    public int Yrs { get; set; }

    public int Hrs { get; set; }

    public int Mins { get; set; }

    public int Mons { get; set; }

    public int? Requestid { get; set; }

    public string? Remark { get; set; }

    public string? ApprovedBy { get; set; }

    public DateTime? ApproveDate { get; set; }

    public string? ToApprove { get; set; }

    public string? IsNotify { get; set; }

    public string? Approvers { get; set; }

    public string? Smstext { get; set; }
}
