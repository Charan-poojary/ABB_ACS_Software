using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class Dashboardsetting
{
    public int Srno { get; set; }

    public string? Dashkey { get; set; }

    public string? Dashtype { get; set; }

    public string? Dashvalue { get; set; }
}
