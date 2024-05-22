using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class Mastermsgdetail
{
    public int Srno { get; set; }

    public int? Taskcode { get; set; }

    public int? Eventcode { get; set; }

    public int? Msgid { get; set; }

    public string? Adfields { get; set; }

    public int? Adcount { get; set; }

    public string? Descr { get; set; }
}
