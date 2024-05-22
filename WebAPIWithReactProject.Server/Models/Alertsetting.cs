using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class Alertsetting
{
    public int Srno { get; set; }

    public string? Alertname { get; set; }

    public string? Authorisednos { get; set; }

    public string? Readerids { get; set; }

    public string? Grantdeny { get; set; }
}
