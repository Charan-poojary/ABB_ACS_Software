using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class Weeklyoff
{
    public int SrNo { get; set; }

    public string? Empid { get; set; }

    public string? Wkoffid { get; set; }

    public string? W1fh { get; set; }

    public string? W1sh { get; set; }

    public string? W2fh { get; set; }

    public string? W2sh { get; set; }

    public string? W3fh { get; set; }

    public string? W3sh { get; set; }

    public string? W4fh { get; set; }

    public string? W4sh { get; set; }

    public string? W5fh { get; set; }

    public string? W5sh { get; set; }

    public string? Flag { get; set; }

    public string? Description { get; set; }

    public DateTime? Dates { get; set; }

    public string? Contflag { get; set; }

    public DateTime? Todates { get; set; }
}
