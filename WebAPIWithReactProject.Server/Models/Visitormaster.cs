using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class Visitormaster
{
    public int Srno { get; set; }

    public string? Visitorname { get; set; }

    public string? Compname { get; set; }

    public string? Phno { get; set; }

    public string? Email { get; set; }

    public string? Flag { get; set; }

    public string? Note { get; set; }

    public string? Addedby { get; set; }

    public string? Photopath { get; set; }

    public string? Addr { get; set; }

    public string? Mobno { get; set; }

    public string? Nationality { get; set; }

    public string? VisitorIdproofNo { get; set; }

    public string? Stateid { get; set; }

    public string? Districtid { get; set; }

    public string? Villageid { get; set; }

    public string? Cardno { get; set; }

    public string? Cardformat { get; set; }

    public string? Noformat { get; set; }

    public string? Idprooftype { get; set; }

    public string? Buildingno { get; set; }

    public string? Floorno { get; set; }

    public string? Visitarea { get; set; }

    public string? Workarea { get; set; }

    public long? Enrollno { get; set; }

    public DateOnly? Svalidfrom { get; set; }

    public DateOnly? Svalidto { get; set; }
}
