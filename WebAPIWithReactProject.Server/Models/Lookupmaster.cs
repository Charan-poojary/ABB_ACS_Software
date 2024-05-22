using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class Lookupmaster
{
    public int Id { get; set; }

    public string? Lookupdata { get; set; }

    public string? Response { get; set; }
}
