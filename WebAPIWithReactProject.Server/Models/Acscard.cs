using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class Acscard
{
    public int Acsid { get; set; }

    public string AcsCardNo { get; set; } = null!;

    public bool InUsed { get; set; }
}
