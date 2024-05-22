using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class DeviceAccessgroup
{
    public int Srno { get; set; }

    public int? Agid { get; set; }

    public string? Agname { get; set; }

    public DateTime? Lastfetchtime { get; set; }

    public int? Cid { get; set; }
}
