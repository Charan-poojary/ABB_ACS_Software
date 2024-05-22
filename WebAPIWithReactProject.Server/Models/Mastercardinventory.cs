using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class Mastercardinventory
{
    public int Cardid { get; set; }

    public string Cardno { get; set; } = null!;

    public string? Cardformat { get; set; }

    public string Noformat { get; set; } = null!;

    public string Status { get; set; } = null!;

    public decimal? Uniqueid { get; set; }

    public string? Forvisitor { get; set; }

    public DateTime? CardAssignedOn { get; set; }
}
