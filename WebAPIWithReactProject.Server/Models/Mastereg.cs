using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class Mastereg
{
    public int Egid { get; set; }

    public string? Egname { get; set; }

    public string? Uploadedyn { get; set; }

    public string? Details { get; set; }

    public string? Notes { get; set; }
}
