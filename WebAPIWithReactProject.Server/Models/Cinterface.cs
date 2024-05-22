using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class Cinterface
{
    public int Srno { get; set; }

    public int? Cid { get; set; }

    public int? Iid { get; set; }

    public string? Types { get; set; }

    public int? Icnt { get; set; }

    public string? Dooropt { get; set; }

    public string? Cnotes { get; set; }
}
