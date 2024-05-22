using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class Masterdgupload
{
    public int Srno { get; set; }

    public int? Dgid { get; set; }

    public int? Cid { get; set; }

    public string? Uploadedyn { get; set; }
}
