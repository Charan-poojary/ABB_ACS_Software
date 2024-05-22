using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class ContractGatepassdetail
{
    public int Srno { get; set; }

    public int? Visitorid { get; set; }

    public DateTime? Intime { get; set; }

    public DateTime? Outtime { get; set; }

    public string? Status { get; set; }

    public string? Notes { get; set; }
}
