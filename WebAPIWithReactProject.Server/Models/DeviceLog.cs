using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class DeviceLog
{
    public int Srno { get; set; }

    public DateTime? Dates { get; set; }

    public int? Majoreventtype { get; set; }

    public int? Minoreventtype { get; set; }

    public int? Cid { get; set; }

    public string? Logdesc { get; set; }

    public DateTime? Downloadtime { get; set; }
}
