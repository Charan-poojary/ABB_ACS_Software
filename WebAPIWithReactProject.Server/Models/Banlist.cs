using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class Banlist
{
    public int Srno { get; set; }

    public int Empid { get; set; }

    public int Visitorid { get; set; }

    public string? Visname { get; set; }

    public string? Addedby { get; set; }

    public string? Note { get; set; }
}
