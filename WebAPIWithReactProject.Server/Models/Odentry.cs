using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class Odentry
{
    public int Srno { get; set; }

    public DateTime? Dates { get; set; }

    public string? Odhrs { get; set; }

    public int? Empid { get; set; }

    public string? Oddetails { get; set; }

    public string? Odnotes { get; set; }

    public string? Odnotes1 { get; set; }

    public DateTime? Compoffdate { get; set; }

    public string? Place { get; set; }
}
