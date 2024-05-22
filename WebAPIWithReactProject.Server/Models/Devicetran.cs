using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class Devicetran
{
    public int Srno { get; set; }

    public DateTime? Dates { get; set; }

    public DateTime? Times { get; set; }

    public decimal? Empid { get; set; }

    public int? Eventcode { get; set; }

    public int? Taskcode { get; set; }

    public int? Msgid { get; set; }

    public string? Transmsg { get; set; }

    public int? Cid { get; set; }

    public int? Rid { get; set; }

    public int? Updated { get; set; }

    public int? Inout { get; set; }

    public string? Tphotopath { get; set; }

    public string? Uniqs { get; set; }

    public string? Cardorunique { get; set; }

    public int? Laptopid { get; set; }

    public int? Vehicleid { get; set; }

    public string? TrFlag { get; set; }

    public string? Ignoreflag { get; set; }

    public string? Transtype { get; set; }
}
