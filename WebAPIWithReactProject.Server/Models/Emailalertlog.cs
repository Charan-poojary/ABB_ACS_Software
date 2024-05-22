using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class Emailalertlog
{
    public int Srno { get; set; }

    public string? Subject { get; set; }

    public string? Mailfrom { get; set; }

    public string? Mailto { get; set; }

    public string? Mailbody { get; set; }

    public DateTime? Datetime { get; set; }

    public string? Details { get; set; }

    public string? Tiltle { get; set; }

    public string? Status { get; set; }

    public string? Reason { get; set; }
}
