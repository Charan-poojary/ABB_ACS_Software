using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class Iorule
{
    public int Srno { get; set; }

    public int? Cid { get; set; }

    public string? Rulename { get; set; }

    public int? Eventmsgno { get; set; }

    public string? Ruleval { get; set; }

    public string? Popup { get; set; }

    public int? Funccode { get; set; }

    public string? Details { get; set; }

    public string? Inputs { get; set; }

    public string? Outputs { get; set; }

    public string? Ruleval2 { get; set; }

    public string? Resetmode { get; set; }

    public string? Resetfunc { get; set; }

    public string? Flipmode { get; set; }

    public string? Bit1 { get; set; }

    public string? Bit2 { get; set; }

    public string? Ionote1 { get; set; }

    public string? Ionote2 { get; set; }

    public string? Ionote3 { get; set; }

    public string? Inverseinput { get; set; }

    public string? Openclose { get; set; }
}
