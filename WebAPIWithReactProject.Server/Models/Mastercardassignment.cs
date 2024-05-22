using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class Mastercardassignment
{
    public int Srno { get; set; }

    public int Cardid { get; set; }

    public int Assigneeid { get; set; }

    public string Assigneetype { get; set; } = null!;

    public DateTime Fromdatetime { get; set; }

    public DateTime? Todatetime { get; set; }

    public DateTime Latestdatetime { get; set; }
}
