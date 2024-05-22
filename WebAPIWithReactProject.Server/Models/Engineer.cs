using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class Engineer
{
    public int Srno { get; set; }

    public int? Eid { get; set; }

    public string? EngineerName { get; set; }

    public string? Ecode { get; set; }

    public string? Contact { get; set; }

    public string? Email { get; set; }

    public string? Address { get; set; }

    public string? CustomerName { get; set; }

    public string? Details { get; set; }
}
