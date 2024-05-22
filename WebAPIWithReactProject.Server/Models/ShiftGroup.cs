using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class ShiftGroup
{
    public long Srno { get; set; }

    public int? Groupid { get; set; }

    public string? Groupname { get; set; }

    public string? Shiftid { get; set; }

    public string? Compid { get; set; }

    public string? Locationid { get; set; }

    public string? Flag { get; set; }

    public string? Description { get; set; }

    public string? Addedby { get; set; }

    public DateTime? Addedtime { get; set; }
}
