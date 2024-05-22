using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class Input
{
    public int Srno { get; set; }

    public int? Cid { get; set; }

    public int? Iid { get; set; }

    public int? Input1 { get; set; }

    public string? Iname { get; set; }

    public string? Ivalue { get; set; }

    public string? Funccode { get; set; }

    public string? Flipmode { get; set; }

    public string? Bit1 { get; set; }

    public string? Bit2 { get; set; }

    public string? Resetmode { get; set; }
}
