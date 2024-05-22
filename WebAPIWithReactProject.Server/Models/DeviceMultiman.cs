using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class DeviceMultiman
{
    public int Srno { get; set; }

    public int? Cid { get; set; }

    public DateTime? Lastfetchtime { get; set; }

    public int? Multimanindx { get; set; }

    public string? Preserveseq { get; set; }

    public string? Seqtimeout { get; set; }

    public string? Entrytype { get; set; }

    public string? Rolescnt { get; set; }

    public string? Roleids { get; set; }
}
