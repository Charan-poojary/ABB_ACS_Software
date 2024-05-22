using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class MLeaf
{
    public int SrNo { get; set; }

    public string? Description { get; set; }

    public string? Abbrevation { get; set; }

    public string? LeaveCode { get; set; }

    public string? PaidUnpaid { get; set; }

    public string? CarryFoward { get; set; }

    public string? Compid { get; set; }

    public string? Locationid { get; set; }

    public string? Usedflag { get; set; }
}
