using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class Otptransaction
{
    public int Srno { get; set; }

    public int? Eid { get; set; }

    public string? Otp { get; set; }

    public string? Panelid { get; set; }

    public string? IsUpload { get; set; }

    public string? IsActive { get; set; }

    public string? Remark { get; set; }

    public DateTime? Dates { get; set; }

    public DateTime? Times { get; set; }
}
