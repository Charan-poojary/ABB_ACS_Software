using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class AccUserRight
{
    public long Srno { get; set; }

    public string? Userid { get; set; }

    public string? Formid { get; set; }

    public string? Formvalue { get; set; }

    public string? Flag { get; set; }

    public string? Notes { get; set; }
}
