using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class DeviceStatus
{
    public int Srno { get; set; }

    public string? Cid { get; set; }

    public DateTime? Lastupdatetime { get; set; }

    public string? Doorlockstatus { get; set; }
}
