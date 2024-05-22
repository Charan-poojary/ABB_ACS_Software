using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class Stmplogtbl
{
    public int Srno { get; set; }

    public string? Workorderno { get; set; }

    public string? Vendor { get; set; }

    public DateTime? Dates { get; set; }

    public string? Training { get; set; }

    public string? Tokenno { get; set; }

    public string? Workarea { get; set; }

    public string? Category { get; set; }
}
