using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class Acsetting
{
    public int Id { get; set; }

    public string? Type { get; set; }

    public string? Value { get; set; }
}
