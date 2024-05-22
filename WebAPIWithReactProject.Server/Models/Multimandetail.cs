using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class Multimandetail
{
    public int Srno { get; set; }

    public int? Ruleid { get; set; }

    public int? Roleid { get; set; }

    public string? Agids { get; set; }
}
