using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class Masterlocksetting
{
    public int Srno { get; set; }

    public int? Cid { get; set; }

    public byte? Id { get; set; }

    public byte? Zoneid { get; set; }

    public byte? Time { get; set; }

    public byte? Forcedenable { get; set; }
}
