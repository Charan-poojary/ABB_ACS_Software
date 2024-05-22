using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class RewardSafetyvoilation
{
    public int Srno { get; set; }

    public int Empid { get; set; }

    public string? Rewards { get; set; }

    public string? Safetyvoilation { get; set; }
}
