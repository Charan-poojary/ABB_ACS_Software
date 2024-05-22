using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class MasterControllerType
{
    public int Srno { get; set; }

    public string? Ctype { get; set; }

    public int? Translimit { get; set; }
}
