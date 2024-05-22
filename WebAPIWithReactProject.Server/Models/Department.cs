using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class Department
{
    public int SrNo { get; set; }

    public string? Deptname { get; set; }

    public string? Details { get; set; }

    public string? Flag { get; set; }

    public string? Compid { get; set; }

    public string? Locationid { get; set; }

    public string? Usedflag { get; set; }
}
