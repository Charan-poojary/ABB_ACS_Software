using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class Employeerenewcancel
{
    public int Empid { get; set; }

    public string? Workorderno { get; set; }

    public string? Tokenno { get; set; }

    public byte? Securitychecked { get; set; }

    public DateOnly? Securitycheckeddate { get; set; }

    public string? Passtype { get; set; }

    public byte? Safetychecked { get; set; }

    public string? Safetyreason { get; set; }

    public byte? Medicalcheked { get; set; }

    public string? Medicalreason { get; set; }

    public byte? Hlchecked { get; set; }

    public string? Hlreason { get; set; }

    public byte? Totalchecked { get; set; }

    public string? Eyetest { get; set; }

    public string? Bp { get; set; }

    public long? Empcode { get; set; }

    public long? Enrollno { get; set; }

    public string? Dopetest { get; set; }

    public string? Usertype { get; set; }

    public byte? Securityrejectflag { get; set; }

    public byte? Iifmskm1 { get; set; }

    public byte? Iifmskm2 { get; set; }

    public byte? Advsafetrai { get; set; }

    public byte? Iifexpwork { get; set; }

    public string? Securityrejectreason { get; set; }

    public DateOnly? Securityrejecteddate { get; set; }

    public string? Category { get; set; }

    public string? Clmspasstype { get; set; }

    public DateTime? Dates { get; set; }

    public string? Eicid { get; set; }

    public byte? Eicchecked { get; set; }

    public int Srno { get; set; }
}
