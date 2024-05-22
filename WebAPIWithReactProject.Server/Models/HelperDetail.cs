using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class HelperDetail
{
    public int Empid { get; set; }

    public string Name { get; set; } = null!;

    public string Otlno { get; set; } = null!;

    public string? Policeverification { get; set; }

    public string? Blacklisted { get; set; }

    public string? DhAutoUnreged { get; set; }

    public long? Enrollno { get; set; }

    public string? DeptName { get; set; }

    public string? Empcode { get; set; }

    public string? Compid { get; set; }

    public string? Locationid { get; set; }

    public string? Section { get; set; }

    public string? Designation { get; set; }

    public int? Accesstype { get; set; }

    public string? Accessgroups { get; set; }

    public string? Pbexemptyn { get; set; }

    public string? Extendedyn { get; set; }

    public string? Pinexemptyn { get; set; }

    public string? Uploadedyn { get; set; }

    public string? Pin { get; set; }

    public string? Dob { get; set; }

    public string? Doj { get; set; }

    public string? Ldate { get; set; }

    public string? Email { get; set; }

    public string? Phno { get; set; }

    public string? Gender { get; set; }

    public string? Paddress { get; set; }

    public string? Caddress { get; set; }

    public string? Status { get; set; }

    public DateTime? Validfrom { get; set; }

    public DateTime? Validto { get; set; }

    public string? Applyvalid { get; set; }

    public string? FatherName { get; set; }

    public int? Roleid { get; set; }

    public int? Inschedelevator { get; set; }

    public int? Outschedelevator { get; set; }

    public string? Pfno { get; set; }

    public byte[]? Photo { get; set; }

    public string? Cardno { get; set; }

    public string? Facilitycode { get; set; }

    public string? Nofmt { get; set; }

    public decimal? Uniqueid { get; set; }
}
