using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class Appointment
{
    public int Srno { get; set; }

    public int? Empid { get; set; }

    public string? Compname { get; set; }

    public string? Contactno { get; set; }

    public string? Address { get; set; }

    public string? Visitorname { get; set; }

    public string? Purpose { get; set; }

    public DateTime? Dates { get; set; }

    public DateTime? Times { get; set; }

    public int? Gatepassno { get; set; }

    public int? Gateno { get; set; }

    public string? Note { get; set; }

    public string? Flag { get; set; }

    public string? Code { get; set; }

    public string? Smstext { get; set; }

    public string? Carrlaptop { get; set; }

    public string? Carrtoolkit { get; set; }

    public string? Carrother { get; set; }

    public string? Carrotherdetails { get; set; }

    public string? Carrmob { get; set; }

    public string? Carrmobwithcamera { get; set; }

    public DateTime? Todate { get; set; }

    public string? Mapproveflag { get; set; }

    public string? Abuildingno { get; set; }

    public string? Afloorno { get; set; }

    public string? Avisitarea { get; set; }

    public string? Aworkarea { get; set; }

    public string? Lapproveflag { get; set; }
}
