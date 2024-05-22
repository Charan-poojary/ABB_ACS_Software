using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class Errorlog
{
    public int Srno { get; set; }

    public string? Error { get; set; }

    public DateTime? Dates { get; set; }
}
