using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class TransactionConfiguration
{
    public int Id { get; set; }

    public string? Param { get; set; }

    public string? Value { get; set; }
}
