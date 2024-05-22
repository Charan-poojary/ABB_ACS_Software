using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class EmpClassification
{
    public int? Srno { get; set; }

    public int? Empid { get; set; }

    public int? Compid { get; set; }

    public int? Locationid { get; set; }

    public int? Deptid { get; set; }

    public int? Desgid { get; set; }

    public int? Sectionid { get; set; }

    public int? Status { get; set; }

    public string? Assignedby { get; set; }

    public DateTime? Assignedon { get; set; }
}
