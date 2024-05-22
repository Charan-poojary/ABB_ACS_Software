using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class Emailalert
{
    public int Srno { get; set; }

    public DateTime? Dates { get; set; }

    public string? Emailids { get; set; }

    public string? Status { get; set; }
}
