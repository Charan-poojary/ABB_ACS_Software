using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class CondoneEntryRequest
{
    public int Srno { get; set; }

    public int Empid { get; set; }

    public DateTime Dates { get; set; }

    public string CondoneType { get; set; } = null!;

    public DateTime CondoneHrs { get; set; }

    public string Details { get; set; } = null!;

    public string Flag { get; set; } = null!;
}
