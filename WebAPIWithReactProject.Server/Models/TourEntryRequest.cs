using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class TourEntryRequest
{
    public int Srno { get; set; }

    public int Empid { get; set; }

    public string Dates { get; set; } = null!;

    public string Mode { get; set; } = null!;

    public string Details { get; set; } = null!;

    public string Flag { get; set; } = null!;
}
