using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class Activitylog
{
    public int Srno { get; set; }

    public int? Priority { get; set; }

    public DateTime? Dates { get; set; }

    public int? Cid { get; set; }

    public string? Activitytype { get; set; }

    public string? Details { get; set; }

    public string? Details1 { get; set; }

    public string? Ipaddress { get; set; }

    public string? Status { get; set; }

    public string? Returncode { get; set; }

    public DateTime? Execdates { get; set; }

    public string? Username { get; set; }
}
