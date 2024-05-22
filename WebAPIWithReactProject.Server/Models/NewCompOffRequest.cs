using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class NewCompOffRequest
{
    public int Srno { get; set; }

    public string? Empid { get; set; }

    public DateTime? Fromdate { get; set; }

    public DateTime? Todate { get; set; }

    public string? Punchtime { get; set; }

    public string? Flag { get; set; }

    public int? Fdmonth { get; set; }

    public int? Fdyear { get; set; }

    public int? Fdday { get; set; }

    public int? Tdmonth { get; set; }

    public int? Tdyear { get; set; }

    public int? Tdday { get; set; }

    public string? Availableot { get; set; }

    public string? Description { get; set; }

    public string? Notes { get; set; }

    public int? Requestid { get; set; }

    public string? Remark { get; set; }

    public string? Cofftype { get; set; }

    public string? ToApprove { get; set; }

    public string? IsNotify { get; set; }

    public string? Approvers { get; set; }

    public string? Smstext { get; set; }
}
