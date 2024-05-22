using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class Customer
{
    public int Srno { get; set; }

    public string? CustomerName { get; set; }

    public string? Details { get; set; }
}
