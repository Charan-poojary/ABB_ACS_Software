using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class Accesstimesupload
{
    public int Srno { get; set; }

    public int? Acctimesrno { get; set; }

    public int? Cid { get; set; }

    public string? Uploadedyn { get; set; }
}
