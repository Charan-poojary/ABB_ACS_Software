using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class AccauditLog
{
    public int Srno { get; set; }

    public string? EventId { get; set; }

    public string? Username { get; set; }

    public DateTime? LogDate { get; set; }

    public DateTime? LogTime { get; set; }

    public int? Day { get; set; }

    public int? Month { get; set; }

    public int? Year { get; set; }

    public string? Flag { get; set; }

    public string? Description { get; set; }
}
