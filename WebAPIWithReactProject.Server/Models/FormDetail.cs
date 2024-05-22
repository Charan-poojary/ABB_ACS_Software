using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class FormDetail
{
    public long Srno { get; set; }

    public string? Formname { get; set; }

    public string? Userlevel { get; set; }

    public string? Flag { get; set; }

    public string? Displayname { get; set; }

    public long? Id { get; set; }
}
