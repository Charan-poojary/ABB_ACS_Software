using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class CanteenTransaction
{
    public int Srno { get; set; }

    public int? Empid { get; set; }

    public int? Vendorid { get; set; }

    public DateTime? Dates { get; set; }

    public double? Total { get; set; }
}
