using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class ClmsEmaillog
{
    public int Srno { get; set; }

    public string? Emailfrom { get; set; }

    public string? Emailto { get; set; }

    public string? Status { get; set; }

    public string? Reason { get; set; }

    public string? Details { get; set; }

    public DateTime? Dates { get; set; }
}
