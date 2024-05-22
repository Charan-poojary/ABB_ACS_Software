using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class LeaveYear
{
    public int Srno { get; set; }

    public DateTime? Finstartyear { get; set; }

    public DateTime? Finendyear { get; set; }

    public string? Notes { get; set; }

    public string? Flag { get; set; }
}
