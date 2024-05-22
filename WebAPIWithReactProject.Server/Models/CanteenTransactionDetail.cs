using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class CanteenTransactionDetail
{
    public int Srno { get; set; }

    public int? Empid { get; set; }

    public int? Vendorid { get; set; }

    public int? Menuid { get; set; }

    public double? Total { get; set; }

    public int? Transid { get; set; }

    public double? Quantity { get; set; }

    public double? Rate { get; set; }

    public DateTime? Dates { get; set; }
}
