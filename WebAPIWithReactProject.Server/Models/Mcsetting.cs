using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class Mcsetting
{
    public int Srno { get; set; }

    public string? Machineno { get; set; }

    public string? Ipaddress { get; set; }

    public string? Flag { get; set; }

    public string? Temp { get; set; }

    public string? Machinetype { get; set; }

    public string? Mcname { get; set; }

    public string? Subnet { get; set; }

    public string? Gateway { get; set; }

    public string? InOutFlag { get; set; }

    public string? InOutmode { get; set; }

    public string? Pushdata { get; set; }

    public string? Connectip { get; set; }
}
