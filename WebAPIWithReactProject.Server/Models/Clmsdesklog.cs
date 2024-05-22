using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class Clmsdesklog
{
    public int Id { get; set; }

    public int? Empid { get; set; }

    public string? Workorderno { get; set; }

    public string? Tokenno { get; set; }

    public string? Clmspasstype { get; set; }

    public DateTime? Datetime { get; set; }
}
