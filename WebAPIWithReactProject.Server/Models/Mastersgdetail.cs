using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class Mastersgdetail
{
    public int Srno { get; set; }

    public int? Sgid { get; set; }

    public int? Htid { get; set; }

    public string? Flag { get; set; }

    public string? Starttime { get; set; }

    public string? Endtime { get; set; }
}
