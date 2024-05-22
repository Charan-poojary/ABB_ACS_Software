using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class GadgetAllowed
{
    public int Srno { get; set; }

    public string? Empid { get; set; }

    public string? Status { get; set; }
}
