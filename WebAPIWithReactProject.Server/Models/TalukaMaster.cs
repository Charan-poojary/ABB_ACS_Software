using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class TalukaMaster
{
    public int TalId { get; set; }

    public int? DisId { get; set; }

    public string? Name { get; set; }
}
