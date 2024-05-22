using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class Masterdg
{
    public int Dgid { get; set; }

    public string? Dgname { get; set; }

    public string? Compid { get; set; }

    public string? Locationid { get; set; }

    public string? Uploadedyn { get; set; }

    public string? Details { get; set; }

    public byte? Fireevent { get; set; }

    public int? Firecid { get; set; }
}
