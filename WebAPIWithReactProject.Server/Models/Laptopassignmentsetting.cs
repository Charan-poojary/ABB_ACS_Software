using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class Laptopassignmentsetting
{
    public int Srno { get; set; }

    public int Inreaderid { get; set; }

    public int Outreaderid { get; set; }

    public int Ignoredurationsec { get; set; }
}
