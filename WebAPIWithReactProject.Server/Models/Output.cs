using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class Output
{
    public int Srno { get; set; }

    public int? Cid { get; set; }

    public int? Iid { get; set; }

    public int? Output1 { get; set; }

    public string? Oname { get; set; }

    public string? Ovalue { get; set; }
}
