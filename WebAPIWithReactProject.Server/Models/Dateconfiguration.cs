using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class Dateconfiguration
{
    public int Srno { get; set; }

    public string? Settingfor { get; set; }

    public DateTime? Fromdate { get; set; }

    public DateTime? Todate { get; set; }

    public string? Continues { get; set; }

    public string? Noofdays { get; set; }

    public string? Remark { get; set; }
}
