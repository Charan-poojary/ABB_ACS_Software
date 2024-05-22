using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class BuildingMaster
{
    public int? Srno { get; set; }

    public string? Name { get; set; }

    public string? Details { get; set; }

    public string? Note { get; set; }

    public string? BuildingNo { get; set; }
}
