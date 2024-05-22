using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class Masterag
{
    public int Agid { get; set; }

    public string? Agname { get; set; }

    public string? Compid { get; set; }

    public string? Locationid { get; set; }

    public string? Uploadedyn { get; set; }

    public string? Details { get; set; }

    public string? Defaultflag { get; set; }
}
