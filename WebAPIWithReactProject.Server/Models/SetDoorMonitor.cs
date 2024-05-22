using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class SetDoorMonitor
{
    public int Srno { get; set; }

    public string? EnableDoorHeld { get; set; }

    public string? EnableDoorForced { get; set; }

    public string? Uploadedyn { get; set; }

    public string? Cleardfalarm { get; set; }
}
