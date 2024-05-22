using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class Multimanmaster
{
    public int Ruleid { get; set; }

    public string? Rulename { get; set; }

    public int? Timeout { get; set; }

    public string? Seqn { get; set; }
}
