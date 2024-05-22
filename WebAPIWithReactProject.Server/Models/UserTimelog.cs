using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class UserTimelog
{
    public int Srno { get; set; }

    public int? Userid { get; set; }

    public int? Type { get; set; }

    public int? Verifymode { get; set; }

    public DateTime? Dates { get; set; }

    public int? Days { get; set; }

    public int? Mons { get; set; }

    public int? Yrs { get; set; }

    public DateTime? Times { get; set; }

    public string? Flag { get; set; }

    public int? Hrs { get; set; }

    public int? Mins { get; set; }
}
