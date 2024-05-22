using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class DoorControl
{
    public int Srno { get; set; }

    public string? Doorname { get; set; }

    public int? Cid { get; set; }

    public int? V100id { get; set; }

    public int? Iid { get; set; }

    public string? Status { get; set; }

    public string? Flag { get; set; }

    public string? Notes { get; set; }
}
