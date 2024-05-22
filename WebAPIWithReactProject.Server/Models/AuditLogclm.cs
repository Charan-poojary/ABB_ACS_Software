using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class AuditLogclm
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

    public string? Workorderno { get; set; }

    public string? Tokenno { get; set; }

    public string? Empcode { get; set; }

    public DateTime? Prevwcdate { get; set; }

    public DateTime? Updatedecdate { get; set; }

    public DateTime? Prevlldate { get; set; }

    public DateTime? Updatedlldate { get; set; }

    public DateTime? Prevtodate { get; set; }

    public DateTime? Updatetodate { get; set; }
}
