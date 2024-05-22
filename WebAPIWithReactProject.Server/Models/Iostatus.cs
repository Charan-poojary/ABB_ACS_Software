using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class Iostatus
{
    public int Srno { get; set; }

    public int? Statusbit { get; set; }

    public string? Details { get; set; }

    public string? Ctype { get; set; }

    public string? Resetmode { get; set; }

    public string? Resetfunc { get; set; }

    public string? Flipmode { get; set; }

    public string? Bit1 { get; set; }

    public string? Bit2 { get; set; }
}
