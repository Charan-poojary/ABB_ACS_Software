using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class Mastereventsv
{
    public int Id { get; set; }

    public string? Code { get; set; }

    public string? Type { get; set; }

    public string? Name { get; set; }

    public string? Details { get; set; }
}
