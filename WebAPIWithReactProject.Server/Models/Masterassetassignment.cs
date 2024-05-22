using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class Masterassetassignment
{
    public int Srno { get; set; }

    public int Laptopid { get; set; }

    public int Empid { get; set; }

    public DateTime Fromdatetime { get; set; }

    public DateTime? Todatetime { get; set; }

    public DateTime Latestdatetime { get; set; }
}
