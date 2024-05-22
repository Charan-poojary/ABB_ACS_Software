using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class Mastercontroller
{
    public int Cid { get; set; }

    public string? Cname { get; set; }

    public string? Ctype { get; set; }

    public int? V100cnt { get; set; }

    public string? V100rcnt { get; set; }

    public string? Ip { get; set; }

    public int? Port { get; set; }

    public int? Readercnt { get; set; }

    public string? Compid { get; set; }

    public string? Locationid { get; set; }

    public string? Flag { get; set; }

    public int? Ciid { get; set; }

    public string? Macaddress { get; set; }

    public string? Ipchange { get; set; }

    public string? Cntuploadedyn { get; set; }

    public string? Status { get; set; }

    public DateTime? Lastconnected { get; set; }

    public int? Normalaccess { get; set; }

    public int? Extendedaccess { get; set; }

    public int? Minopen { get; set; }

    public int? Doorheld { get; set; }

    public string? Doorheldyn { get; set; }

    public int? V200cnt { get; set; }

    public int? V300cnt { get; set; }

    public string? Fversion { get; set; }

    public DateTime? Lastconnecttime { get; set; }

    public string? Cusername { get; set; }

    public string? Cpass { get; set; }

    public string? Pushmode { get; set; }

    public string? Mode { get; set; }

    public string? Onlyattendance { get; set; }

    public string? Capsnapshot { get; set; }

    public string? Terminalid { get; set; }

    public string? Firmwareversion { get; set; }

    public string? Timezone { get; set; }

    public int? Authmode { get; set; }

    public int? Timesync { get; set; }

    public int? Globalpassback { get; set; }

    public int? Cardreadformat { get; set; }

    public int? Serialformat { get; set; }

    public byte Isenroller { get; set; }
}
