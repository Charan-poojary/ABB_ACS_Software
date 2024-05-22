using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class AccMasterreader
{
    public int Rid { get; set; }

    public int? Rno { get; set; }

    public string? Rname { get; set; }

    public string? Rtype { get; set; }

    public int? Cid { get; set; }

    public string? Compid { get; set; }

    public string? Locationid { get; set; }

    public string? Uploadedyn { get; set; }

    public string? Attyn { get; set; }

    public string? Iostatus { get; set; }

    public int? Normal { get; set; }

    public int? Doorheld { get; set; }

    public string? Rnotes { get; set; }

    public string? Rnotes1 { get; set; }

    public string? Rnotes2 { get; set; }

    public string? Mainentryorexit { get; set; }
}
