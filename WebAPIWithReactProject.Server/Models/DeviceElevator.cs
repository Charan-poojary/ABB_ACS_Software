using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class DeviceElevator
{
    public int Srno { get; set; }

    public int? Cid { get; set; }

    public DateTime? Lastfetchtime { get; set; }

    public int? Grpid { get; set; }

    public int? Iid { get; set; }

    public int? Ifid { get; set; }

    public string? Relays { get; set; }

    public int? Readerid { get; set; }
}
