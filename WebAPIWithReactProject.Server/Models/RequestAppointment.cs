using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class RequestAppointment
{
    public int Srno { get; set; }

    public int? Empid { get; set; }

    public string? Compname { get; set; }

    public string? Contactno { get; set; }

    public string? Address { get; set; }

    public string? Visitorname { get; set; }

    public string? Purpose { get; set; }

    public DateTime? Todate { get; set; }

    public DateTime? Fromdate { get; set; }

    public DateTime? Times { get; set; }

    public int? Gatepassno { get; set; }

    public int? Gateno { get; set; }

    public string? Note { get; set; }

    public string? Flag { get; set; }

    public string? Code { get; set; }

    public string? Smstext { get; set; }

    public string? Host { get; set; }

    public string? Status { get; set; }

    public string? Updated { get; set; }

    public string? Carrlaptop { get; set; }

    public string? Carrtoolkit { get; set; }

    public string? Carrother { get; set; }

    public string? Carrotherdetails { get; set; }

    public string? Carrmob { get; set; }

    public string? Carrmobwithcamera { get; set; }

    public string? Mapproveflag { get; set; }

    public string? Approvevisitor { get; set; }

    public int? State { get; set; }

    public int? Village { get; set; }

    public int? Dist { get; set; }

    public string? Idproof { get; set; }

    public string? Idtype { get; set; }

    public string? Buildingno { get; set; }

    public string? Floorno { get; set; }

    public string? Visitarea { get; set; }

    public string? Workarea { get; set; }

    public string? Email { get; set; }

    public string? Nationality { get; set; }

    public string? Lapproveflag { get; set; }

    public string? Requeststatus { get; set; }
}
