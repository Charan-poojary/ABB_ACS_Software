using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class Sm
{
    public int Srno { get; set; }

    public string? Sender { get; set; }

    public string? Message { get; set; }

    public string? Sent { get; set; }

    public string? Status { get; set; }

    public string? Kyword { get; set; }

    public DateTime? Entrydate { get; set; }

    public DateTime? Entrytime { get; set; }

    public string? Num { get; set; }

    public string? Replystatus { get; set; }

    public string? Msgdetails { get; set; }

    public string? Msgnotes { get; set; }
}
