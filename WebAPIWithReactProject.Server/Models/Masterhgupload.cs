using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class Masterhgupload
{
    public int Srno { get; set; }

    public int? Hgid { get; set; }

    public int? Cid { get; set; }

    public string? Uploadedyn { get; set; }
}
