using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class Masteragdetail
{
    public int Srno { get; set; }

    public int? Agid { get; set; }

    public int? Dgid { get; set; }

    public int? Sgid { get; set; }

    public string? Flag { get; set; }
}
