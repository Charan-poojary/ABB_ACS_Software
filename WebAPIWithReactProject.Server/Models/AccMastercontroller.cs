using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class AccMastercontroller
{
    public int Cid { get; set; }

    public string? Cname { get; set; }

    public string? Doorconfig { get; set; }

    public string? Ip { get; set; }

    public int? Port { get; set; }

    public int? Readercnt { get; set; }

    public string? Compid { get; set; }

    public string? Locationid { get; set; }

    public string? Flag { get; set; }

    public string? Cntuploadedyn { get; set; }

    public string? Status { get; set; }

    public DateTime? Lastconnected { get; set; }

    public int? Normalaccess { get; set; }

    public string? Doorheldyn { get; set; }

    public int? Lasttransid { get; set; }

    public string? Timezone { get; set; }
}
