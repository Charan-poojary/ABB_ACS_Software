using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class Alertlog
{
    public int Srno { get; set; }

    public int? Alertid { get; set; }

    public string? Readerid { get; set; }

    public DateTime? Logtime { get; set; }

    public string? Details { get; set; }

    public string? Mobnos { get; set; }
}
