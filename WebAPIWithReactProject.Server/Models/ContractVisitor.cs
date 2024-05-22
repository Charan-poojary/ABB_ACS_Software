using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class ContractVisitor
{
    public int Srno { get; set; }

    public string? Visname { get; set; }

    public string? Compname { get; set; }

    public string? Address { get; set; }

    public string? Phno { get; set; }

    public byte[]? Image { get; set; }

    public byte[]? Fpimage { get; set; }

    public byte[]? Fpdata { get; set; }

    public string? Flag { get; set; }

    public string? Tmpsize { get; set; }

    public string? Addedby { get; set; }

    public byte[]? SigImage { get; set; }

    public string? Stateid { get; set; }

    public string? Districtid { get; set; }

    public string? Villageid { get; set; }

    public string? Cardno { get; set; }

    public string? Cardformat { get; set; }

    public string? Noformat { get; set; }

    public string? Idtype { get; set; }

    public string? Idproof { get; set; }

    public int? Visid { get; set; }
}
