using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class ConfigFile
{
    public int Srno { get; set; }

    public int? Cid { get; set; }

    public string? Filepath { get; set; }

    public string? Filetype { get; set; }

    public string? Ids { get; set; }

    public string? Names { get; set; }

    public string? Macaddr { get; set; }

    public string? Controllerpath { get; set; }

    public string? Cname { get; set; }
}
