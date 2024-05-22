using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class ControlTaskLog
{
    public int Srno { get; set; }

    public DateTime? Dates { get; set; }

    public DateTime? Times { get; set; }

    public string? Task { get; set; }

    public string? Status { get; set; }

    public int? Cid { get; set; }
}
