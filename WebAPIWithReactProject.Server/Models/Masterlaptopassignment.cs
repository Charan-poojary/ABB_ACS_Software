using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class Masterlaptopassignment
{
    public int Srno { get; set; }

    public int Laptopid { get; set; }

    public int Empid { get; set; }

    public DateTime Fromdatetime { get; set; }

    public int Fromtrsrno { get; set; }

    public int Fromtrmonth { get; set; }

    public int Fromtryear { get; set; }

    public DateTime? Todatetime { get; set; }

    public int? Totrsrno { get; set; }

    public int? Totrmonth { get; set; }

    public int? Totryear { get; set; }

    public DateTime Latestdatetime { get; set; }
}
