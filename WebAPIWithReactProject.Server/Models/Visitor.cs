using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class Visitor
{
    public decimal Vid { get; set; }

    public string? VisitorCode { get; set; }

    public string? Visitorname { get; set; }

    public string? Email { get; set; }

    public string? Phno { get; set; }

    public string? Caddress { get; set; }

    public string? Cardno { get; set; }

    public string? Compid { get; set; }

    public string? Status { get; set; }

    public string? Locationid { get; set; }

    public string? Host { get; set; }

    public DateTime? Dates { get; set; }

    public DateTime? Intime { get; set; }

    public DateTime? Outtime { get; set; }
}
