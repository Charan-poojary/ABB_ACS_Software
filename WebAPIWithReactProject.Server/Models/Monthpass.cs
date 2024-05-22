using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class Monthpass
{
    public int Srno { get; set; }

    public int Gateno { get; set; }

    public int? Passno { get; set; }

    public string? Visitorname { get; set; }

    public string? Compnay { get; set; }

    public string? Address { get; set; }

    public string? Phno { get; set; }

    public DateTime? Fromdate { get; set; }

    public DateTime? Todate { get; set; }

    public string? Type { get; set; }

    public string? Flag { get; set; }

    public string? Createdby { get; set; }

    public DateTime? Createdon { get; set; }

    public string? Location { get; set; }

    public string? Dept { get; set; }

    public string? Powonumber { get; set; }

    public string? AcsCardNo { get; set; }

    public string? Zno { get; set; }

    public byte[]? Barcode { get; set; }

    public string? Barcodedata { get; set; }

    public string? Idtype { get; set; }

    public string? Idproof { get; set; }

    public string? Tomeet { get; set; }

    public string? Empid { get; set; }

    public string? Cardno { get; set; }

    public int? Visid { get; set; }

    public string? Processedautovaliditysignout { get; set; }
}
