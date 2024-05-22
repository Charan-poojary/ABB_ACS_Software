using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class Client
{
    public int Srno { get; set; }

    public string? Clientid { get; set; }

    public string? Keys { get; set; }

    public string? Clientname { get; set; }
}
