using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class Masterassetsetting
{
    public int Srno { get; set; }

    public string? Controllerids { get; set; }

    public string? Inreaderids { get; set; }

    public string? Outreaderids { get; set; }

    public string? Inoutreaderids { get; set; }

    public int? Ignorepuncheswithinminutes { get; set; }
}
