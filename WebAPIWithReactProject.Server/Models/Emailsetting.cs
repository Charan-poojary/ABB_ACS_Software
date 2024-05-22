using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class Emailsetting
{
    public int Srno { get; set; }

    public string? Username { get; set; }

    public string? Pass { get; set; }

    public string? Portno { get; set; }

    public string? Server { get; set; }

    public string? Essl { get; set; }

    public string? Apply { get; set; }

    public string? Emailtext { get; set; }

    public string? Setalert { get; set; }

    public string? Emailids { get; set; }
}
