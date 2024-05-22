using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class RequestMail
{
    public long Srno { get; set; }

    public long? Reqid { get; set; }

    public long? Userid { get; set; }

    public string? Reqtype { get; set; }

    public string? Emailid { get; set; }

    public string? Flag { get; set; }

    public string? Notes { get; set; }

    public DateTime? Dates { get; set; }

    public string? Loginid { get; set; }

    public string? Entryon { get; set; }
}
