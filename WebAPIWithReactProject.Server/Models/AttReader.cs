using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class AttReader
{
    public int Srno { get; set; }

    public int? ControllerNo { get; set; }

    public string? ControllerName { get; set; }

    public string? Flag { get; set; }

    public string? Compid { get; set; }

    public string? Locationid { get; set; }
}
