using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class Mastervehicle
{
    public int Vehicleid { get; set; }

    public string? Vehicleno { get; set; }

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

    public decimal? Uniqueid { get; set; }

    public string? Controllergroupids { get; set; }

    public string? Controllerids { get; set; }

    public long? Enrollno { get; set; }

    public DateTime? Createdate { get; set; }

    public DateTime? Modificationdate { get; set; }

    public byte Type { get; set; }

    public string? Dlno { get; set; }

    public string? Drivername { get; set; }
}
