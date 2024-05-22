using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class Message
{
    public int Srno { get; set; }

    public string? Type { get; set; }

    public string? Popup { get; set; }

    public string? Banner { get; set; }

    public string? Popupflag { get; set; }

    public string? Bannerflag { get; set; }
}
