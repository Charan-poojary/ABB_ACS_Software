using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class SetAccesstime
{
    public int Srno { get; set; }

    public double? Ngatime { get; set; }

    public double? Egatime { get; set; }

    public double? Minopentime { get; set; }

    public double? Doorheldtime { get; set; }

    public string? Uploadedyn { get; set; }
}
