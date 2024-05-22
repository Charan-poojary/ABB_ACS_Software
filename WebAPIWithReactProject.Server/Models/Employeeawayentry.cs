using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class Employeeawayentry
{
    public int Srno { get; set; }

    public int Empid { get; set; }

    public DateTime Fromdatetime { get; set; }

    public DateTime Todatetime { get; set; }

    public string Fromprocessed { get; set; } = null!;

    public string Toprocessed { get; set; } = null!;

    public DateTime Addeddatetime { get; set; }
}
