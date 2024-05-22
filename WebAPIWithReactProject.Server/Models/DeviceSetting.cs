using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class DeviceSetting
{
    public int Srno { get; set; }

    public string? Cardincardout { get; set; }

    public string? V100 { get; set; }

    public string? V200 { get; set; }

    public string? V300 { get; set; }

    public string? Noofcards { get; set; }

    public DateTime? Lastfetchtime { get; set; }

    public int? Cid { get; set; }

    public int? Translogsize { get; set; }
}
