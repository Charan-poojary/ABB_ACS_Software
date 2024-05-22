using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class MaterialEmailMaster
{
    public int Srno { get; set; }

    public string? Email { get; set; }

    public string? Flag { get; set; }
}
