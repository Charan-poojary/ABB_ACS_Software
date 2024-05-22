using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class MHoliday
{
    public int SrNo { get; set; }

    public string? Holidayname { get; set; }

    public DateTime? HDate { get; set; }

    public string? Flag { get; set; }

    public int? Days { get; set; }

    public int? Mons { get; set; }

    public int? Years { get; set; }

    public string? Compid { get; set; }

    public string? Locationid { get; set; }

    public string? Usedflag { get; set; }

    public DateTime? HToDate { get; set; }
}
