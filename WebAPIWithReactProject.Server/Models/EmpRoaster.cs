using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class EmpRoaster
{
    public int Srno { get; set; }

    public int? Empid { get; set; }

    public string? Patternname { get; set; }

    public DateTime? Dates { get; set; }
}
