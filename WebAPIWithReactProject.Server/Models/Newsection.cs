using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class Newsection
{
    public int Srno { get; set; }

    public string? Section { get; set; }

    public string? Details { get; set; }

    public string? Notes { get; set; }

    public string? Flag { get; set; }
}
