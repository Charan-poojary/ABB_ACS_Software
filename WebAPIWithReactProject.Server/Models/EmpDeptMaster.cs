using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class EmpDeptMaster
{
    public int Srno { get; set; }

    public string? Empid { get; set; }

    public string? Deptid { get; set; }

    public DateTime? Assignedon { get; set; }

    public string? Assignedby { get; set; }

    public string? Details { get; set; }

    public DateTime? Startdate { get; set; }

    public DateTime? Enddate { get; set; }
}
