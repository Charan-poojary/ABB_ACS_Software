using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class Failnotify
{
    public int Srno { get; set; }

    public DateTime? Dates { get; set; }

    public int? Cid { get; set; }

    public string? Cip { get; set; }

    public string? Emailids { get; set; }
}
