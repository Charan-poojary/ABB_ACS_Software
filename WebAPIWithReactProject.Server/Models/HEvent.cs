using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class HEvent
{
    public int Srno { get; set; }

    public string? Eventdesc { get; set; }

    public string? Eventcode { get; set; }
}
