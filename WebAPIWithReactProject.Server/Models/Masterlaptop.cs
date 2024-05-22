using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class Masterlaptop
{
    public int Laptopid { get; set; }

    public string? Make { get; set; }

    public string? Tagno { get; set; }

    public string? Details { get; set; }

    public string? Accessgroups { get; set; }

    public string? Cardformat { get; set; }

    public string? Noformat { get; set; }

    public string? Empid { get; set; }

    public string? Applyvalid { get; set; }

    public DateTime? Validfrom { get; set; }

    public DateTime? Validto { get; set; }

    public string? Status { get; set; }

    public string? Serialno { get; set; }

    public DateTime? Lastread { get; set; }

    public decimal? Uniqueid { get; set; }

    public int Assettypeid { get; set; }

    public string? Assetno { get; set; }

    public string? Title { get; set; }

    public string? Modelno { get; set; }

    public string? Brandname { get; set; }

    public string? Manufacturer { get; set; }

    public DateTime? Stockdate { get; set; }

    public int? Lastinoutmode { get; set; }

    public DateTime? Lastdatetime { get; set; }
}
