using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class StateMaster
{
    public int Srno { get; set; }

    public string? Statename { get; set; }

    public string? Details { get; set; }

    public string? Flag { get; set; }

    public string? Phno { get; set; }

    public string? Emailid { get; set; }

    public DateTime? Finstartyear { get; set; }

    public DateTime? Finendyear { get; set; }

    public string? Usedflag { get; set; }

    public byte[]? Logo { get; set; }
}
