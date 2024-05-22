using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class Visitorentry
{
    public int Visitorid { get; set; }

    public string? Company { get; set; }

    public string? Address { get; set; }

    public string? Visitorname { get; set; }

    public int? Viscount { get; set; }

    public string? Purpose { get; set; }

    public string? Phno { get; set; }

    public string? Vehicle { get; set; }

    public string? Vehicletype { get; set; }

    public string? Vehicleno { get; set; }

    public string? Depolaptop { get; set; }

    public string? Depomobile { get; set; }

    public string? Depoother { get; set; }

    public string? Depootherdetails { get; set; }

    public string? Carrylaptop { get; set; }

    public string? Carrytoolkit { get; set; }

    public string? Carryother { get; set; }

    public string? Carryotherdetails { get; set; }

    public DateTime Date { get; set; }

    public DateTime Intime { get; set; }

    public string? Status { get; set; }

    public string? Notes { get; set; }

    public string? Mobileno { get; set; }

    public string? Visitortype { get; set; }

    public string? Nationality { get; set; }

    public string? Email { get; set; }
}
