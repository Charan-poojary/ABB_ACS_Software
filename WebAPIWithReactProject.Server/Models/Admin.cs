using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class Admin
{
    public int Srno { get; set; }

    public string? Uname { get; set; }

    public string? Pass { get; set; }

    public string? Type { get; set; }

    public int? Empid { get; set; }

    public string? Flag { get; set; }

    public string? Details { get; set; }

    public string? Addedby { get; set; }

    public string? Fname { get; set; }

    public string? Lname { get; set; }

    public string? Mobno { get; set; }

    public string? Email { get; set; }

    public string? Lastlogin { get; set; }

    public string? Compid { get; set; }

    public string? Locationid { get; set; }

    public string? Dept { get; set; }

    public string? Names { get; set; }

    public string? Phno { get; set; }

    public string? Notes { get; set; }

    public string? Utype { get; set; }

    public string? Accesscontrol { get; set; }

    public string? Attendance { get; set; }

    public string? Controllerids { get; set; }

    public string? Allcontrollers { get; set; }

    public string? Accessgroupids { get; set; }

    public string? Allaccessgroups { get; set; }

    public int? Logintype { get; set; }

    public byte Vmsflag { get; set; }
}
