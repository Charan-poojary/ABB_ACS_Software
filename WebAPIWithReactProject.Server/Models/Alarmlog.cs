using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class Alarmlog
{
    public int Srno { get; set; }

    public DateTime? Dates { get; set; }

    public DateTime? Times { get; set; }

    public string? Alarmtype { get; set; }

    public string? Alarmdesc { get; set; }

    public int? Cid { get; set; }

    public int? Rid { get; set; }

    public string? Flag { get; set; }

    public string? Flag1 { get; set; }

    public string? Flag2 { get; set; }

    public string? Showflag { get; set; }

    public string? Ack { get; set; }

    public DateTime? Ackdatetimes { get; set; }

    public string? Smssentstatus { get; set; }

    public string? Emailsentstatus { get; set; }
}
