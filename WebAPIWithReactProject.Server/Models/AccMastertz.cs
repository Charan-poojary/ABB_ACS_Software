using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class AccMastertz
{
    public int Tzid { get; set; }

    public string? Tzname { get; set; }

    public int? Day { get; set; }

    public DateTime? Starttime { get; set; }

    public DateTime? Endtime { get; set; }
}
