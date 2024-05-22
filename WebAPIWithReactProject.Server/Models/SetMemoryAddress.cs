using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class SetMemoryAddress
{
    public int Srno { get; set; }

    public string? Memadd { get; set; }

    public string? Datastored { get; set; }

    public string? Cnttype { get; set; }
}
