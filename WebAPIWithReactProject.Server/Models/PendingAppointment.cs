using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class PendingAppointment
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

    public string? Host { get; set; }

    public string? Status { get; set; }

    public string? Updated { get; set; }

    public string? Carrlaptop { get; set; }

    public string? Carrtoolkit { get; set; }

    public string? Carrother { get; set; }

    public string? Carrotherdetails { get; set; }

    public string? Carrmob { get; set; }

    public string? Carrmobwithcamera { get; set; }
}
