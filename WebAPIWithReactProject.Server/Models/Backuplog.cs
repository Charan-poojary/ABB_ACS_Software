using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class Backuplog
{
    public int Srno { get; set; }

    public DateTime? Dates { get; set; }

    public string? Times { get; set; }

    public string? Backuppath { get; set; }

    public string? Lognotes { get; set; }

    public string? Lognotes1 { get; set; }

    public string? Lognotes2 { get; set; }

    public string? Logerror { get; set; }

    public string? Backupstatus { get; set; }
}
