using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class CardFormat
{
    public int Srno { get; set; }

    public string? Formatname { get; set; }

    public int? Facilitycode { get; set; }

    public string? Filepath { get; set; }

    public string? Flag { get; set; }

    public string? Uploadedyn { get; set; }

    public int? Noofbits { get; set; }

    public byte[]? Filedata { get; set; }
}
