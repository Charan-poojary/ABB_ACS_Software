using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class Acueventlog
{
    public int Id { get; set; }

    public string? Code { get; set; }

    public int? Account { get; set; }

    public int? Qualifier { get; set; }

    public int? Partition { get; set; }

    public int? Targetid { get; set; }

    public DateTime? Datetime { get; set; }

    public int? Cid { get; set; }

    public string? Terminalid { get; set; }
}
