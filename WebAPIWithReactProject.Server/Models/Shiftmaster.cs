using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class Shiftmaster
{
    public int SrNo { get; set; }

    public string? ShiftCode { get; set; }

    public string? ShiftName { get; set; }

    public string? StartTime { get; set; }

    public string? BreakStart { get; set; }

    public string? BreakEnd { get; set; }

    public string? EndTime { get; set; }

    public string? LateTolerance { get; set; }

    public string? ShortTolerance { get; set; }

    public string? ChkShfBfrTolerance { get; set; }

    public string? ChkShfAftTolerance { get; set; }

    public string? OtTolerance { get; set; }

    public string? NightShift { get; set; }

    public int? Firstdaypunchescnt { get; set; }

    public int? Seconddaypunchcnt { get; set; }

    public string? Defaultflag { get; set; }

    public string? Compid { get; set; }

    public string? Locationid { get; set; }

    public string? Shiftwrkhrs { get; set; }

    public string? Shifthalfdayhrs { get; set; }

    public string? Daystarttime { get; set; }

    public string? Dayendtime { get; set; }

    public int? Dayflag { get; set; }

    public string? Usedflag { get; set; }

    public string? Section { get; set; }

    public string? Shiftflag { get; set; }

    public string? Flag1 { get; set; }

    public string? Flag2 { get; set; }
}
