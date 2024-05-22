using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class AccTran
{
    public int Srno { get; set; }

    public int? Empid { get; set; }

    public string? Cardno { get; set; }

    public DateTime? Dates { get; set; }

    public DateTime? Times { get; set; }

    public int? Status { get; set; }

    public int? Rid { get; set; }

    public int? Cid { get; set; }

    public string? Flag { get; set; }

    public string? Inout { get; set; }
}
