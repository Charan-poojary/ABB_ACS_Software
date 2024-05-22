using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class ProfileFormDetail
{
    public int Srno { get; set; }

    public string? Profilename { get; set; }

    public int? Formheight { get; set; }

    public int? Formwidth { get; set; }

    public string? Backcolor { get; set; }
}
