using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class VisitorCardUpload
{
    public int Srno { get; set; }

    public int? Cardno { get; set; }

    public int? Cid { get; set; }

    public string? Uploadedyn { get; set; }
}
