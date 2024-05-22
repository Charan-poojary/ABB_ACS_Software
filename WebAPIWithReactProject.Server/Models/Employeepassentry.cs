using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class Employeepassentry
{
    public int Srno { get; set; }

    public string? Empid { get; set; }

    public string? EntryDate { get; set; }

    public string? Empcode { get; set; }

    public string? Entrytime { get; set; }
}
