using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class EmpViolationStatus
{
    public int Srno { get; set; }

    public int? Empid { get; set; }

    public int? Uniqueid { get; set; }

    public string? Lastdate { get; set; }

    public string? Lasttime { get; set; }

    public byte[]? Currentarea { get; set; }

    public string? Cardholderstatus { get; set; }

    public int? Violationtype { get; set; }

    public string? Violationarea { get; set; }

    public int? Violationaction { get; set; }

    public int? Lastreadercontroller { get; set; }

    public int? Lastreaderinterfaceaddress { get; set; }

    public int? Lastreaderaddress { get; set; }

    public string? Flag { get; set; }

    public string? Changestatus { get; set; }

    public string? Uploadedyn { get; set; }

    public string? Description { get; set; }
}
