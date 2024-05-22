using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class Versionmaster
{
    public int Srno { get; set; }

    public string? DbVersion { get; set; }

    public string? Footertext { get; set; }

    public string? Swversion { get; set; }

    public DateTime? Releasedate { get; set; }
}
