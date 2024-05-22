using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class Odrequest
{
    public int Srno { get; set; }

    public int? Requestid { get; set; }

    public DateTime? Dates { get; set; }

    public string? Fromtime { get; set; }

    public string? Totime { get; set; }

    public int? Empid { get; set; }

    public DateTime? Requestdate { get; set; }

    public string? Approvedfrom { get; set; }

    public string? Approvedto { get; set; }

    public string? Status { get; set; }

    public string? Odflag { get; set; }

    public string? Oddetails { get; set; }

    public string? Odnotes { get; set; }

    public string? Odnotes1 { get; set; }
}
