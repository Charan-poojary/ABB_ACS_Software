using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class NationalityMaster
{
    public int Srno { get; set; }

    public string? Nationality { get; set; }

    public string? Flag { get; set; }
}
