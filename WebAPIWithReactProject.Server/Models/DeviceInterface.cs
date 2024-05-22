using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class DeviceInterface
{
    public int Srno { get; set; }

    public string? Interfaceid { get; set; }

    public string? Cardincardout { get; set; }

    public int? Cid { get; set; }
}
