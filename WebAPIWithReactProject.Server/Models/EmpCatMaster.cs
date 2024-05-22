using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class EmpCatMaster
{
    public int Srno { get; set; }

    public string? Catname { get; set; }

    public DateTime? Dates { get; set; }

    public int? Empid { get; set; }

    public int? Days { get; set; }

    public int? Months { get; set; }

    public int? Years { get; set; }
}
