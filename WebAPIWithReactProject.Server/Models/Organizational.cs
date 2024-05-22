using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class Organizational
{
    public string? Orgname { get; set; }

    public string? Address { get; set; }

    public string? Phno { get; set; }

    public string? Email { get; set; }

    public byte[]? Logo { get; set; }
}
