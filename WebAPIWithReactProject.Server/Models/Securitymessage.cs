using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class Securitymessage
{
    public int Srno { get; set; }

    public string? Message { get; set; }

    public int Empid { get; set; }

    public string? Flag { get; set; }
}
