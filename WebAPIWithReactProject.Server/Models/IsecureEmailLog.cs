using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class IsecureEmailLog
{
    public string? Type { get; set; }

    public string? From { get; set; }

    public string? To { get; set; }

    public string? Status { get; set; }

    public int Srno { get; set; }

    public string? Details { get; set; }
}
