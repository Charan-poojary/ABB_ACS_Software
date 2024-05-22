using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class VendorMenuMaster
{
    public int Srno { get; set; }

    public int? Menuid { get; set; }

    public int? Venderid { get; set; }

    public double? Rate { get; set; }

    public double? Quantity { get; set; }

    public string? Type { get; set; }

    public byte[]? Image { get; set; }

    public string? Name { get; set; }

    public string? Timeflag { get; set; }

    public DateTime? Fromtime { get; set; }

    public DateTime? Totime { get; set; }

    public string? Deleteflag { get; set; }
}
