using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class OdentryRequest
{
    public int Srno { get; set; }

    public int Empid { get; set; }

    public DateTime Dates { get; set; }

    public DateTime Punchtime { get; set; }

    public string Details { get; set; } = null!;

    public string Flag { get; set; } = null!;

    public string? Punchtype { get; set; }

    public string? Typeflag { get; set; }

    public string? Lastpunch { get; set; }

    public int? Requestid { get; set; }
}
