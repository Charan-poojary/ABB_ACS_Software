using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class Masterrole
{
    public int Roleid { get; set; }

    public string? Rolename { get; set; }

    public string? Details { get; set; }

    public string? Fromdate { get; set; }

    public string? Todate { get; set; }

    public int? Groupid { get; set; }
}
