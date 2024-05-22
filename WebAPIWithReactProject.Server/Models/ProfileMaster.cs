using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class ProfileMaster
{
    public int Srno { get; set; }

    public string? Profilename { get; set; }

    public string? Fieldname { get; set; }

    public int? Topposition { get; set; }

    public int? Leftposition { get; set; }

    public string? Displaytext { get; set; }

    public string? Flag { get; set; }

    public string? Forecolour { get; set; }

    public string? Fontname { get; set; }

    public string? Fontsize { get; set; }

    public string? Bold { get; set; }

    public string? Italic { get; set; }

    public string? Underline { get; set; }
}
