using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class PeerGroup
{
    public int Pgrpid { get; set; }

    public string? Pgrpname { get; set; }

    public string? Ridstring { get; set; }

    public string? Uploadedyn { get; set; }

    public string? Compid { get; set; }

    public string? Locationid { get; set; }
}
