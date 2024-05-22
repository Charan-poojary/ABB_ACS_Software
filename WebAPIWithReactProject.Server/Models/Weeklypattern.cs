using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class Weeklypattern
{
    public int Srno { get; set; }

    public string? Pname { get; set; }

    public string? Sunday { get; set; }

    public string? Monday { get; set; }

    public string? Tuesday { get; set; }

    public string? Wednesday { get; set; }

    public string? Thursday { get; set; }

    public string? Friday { get; set; }

    public string? Saturday { get; set; }
}
