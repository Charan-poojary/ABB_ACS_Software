using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class BioMetric
{
    public long AutoId { get; set; }

    public string TruckId { get; set; } = null!;

    public int? Type { get; set; }

    public int Location { get; set; }

    public string? LocationName { get; set; }

    public DateTime DateAndTime { get; set; }

    public bool IsNew { get; set; }

    public string? Remarks { get; set; }
}
