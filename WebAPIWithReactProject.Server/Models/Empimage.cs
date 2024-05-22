using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class Empimage
{
    public int Id { get; set; }

    public int? Empid { get; set; }

    public byte[]? Employeeimg { get; set; }
}
