using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class BusMaster
{
    public int Srno { get; set; }

    public string? Buscode { get; set; }

    public string? Busroute { get; set; }

    public string? Compid { get; set; }

    public string? Locationid { get; set; }
}
