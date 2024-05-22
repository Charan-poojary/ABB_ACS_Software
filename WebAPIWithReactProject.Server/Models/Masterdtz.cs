using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class Masterdtz
{
    public int Tzid { get; set; }

    public string? Tzname { get; set; }

    public string? Compid { get; set; }

    public string? Locationid { get; set; }

    public string? Uploadedyn { get; set; }

    public string? Details { get; set; }
}
