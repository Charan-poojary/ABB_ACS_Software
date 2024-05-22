using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class Masteragupload
{
    public int Srno { get; set; }

    public int? Agid { get; set; }

    public int? Cid { get; set; }

    public string? Uploadedyn { get; set; }
}
