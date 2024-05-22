using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class Recharge
{
    public int Srno { get; set; }

    public int? Menuid { get; set; }

    public int? Empid { get; set; }

    public DateTime? Validfrom { get; set; }

    public DateTime? Validto { get; set; }

    public DateTime? Addedon { get; set; }

    public double? Recharge1 { get; set; }

    public double? Used { get; set; }

    public double? Balance { get; set; }
}
