using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class MenuMaster
{
    public int Srno { get; set; }

    public string? Name { get; set; }

    public string? Details { get; set; }

    public string? Type { get; set; }

    public string? Flag { get; set; }
}
