using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class DeviceReader
{
    public int Srno { get; set; }

    public int? Rid { get; set; }

    public int? Rno { get; set; }

    public string? Iid { get; set; }

    public string? Accesstype { get; set; }

    public string? Apbtype { get; set; }

    public string? Apbtimeout { get; set; }

    public string? Apbaction { get; set; }

    public string? Normal { get; set; }

    public string? Extended { get; set; }

    public string? Minimum { get; set; }

    public string? Doorheld { get; set; }

    public int? Ruleid { get; set; }

    public DateTime? Lastfetchtime { get; set; }

    public int? Cid { get; set; }

    public string? Rtype { get; set; }
}
