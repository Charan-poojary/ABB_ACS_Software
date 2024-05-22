using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class Masterhg
{
    public int Hgid { get; set; }

    public string? Hgname { get; set; }

    public string? Compid { get; set; }

    public string? Locationid { get; set; }

    public string? Uploadedyn { get; set; }

    public string? Details { get; set; }
}
