using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class ProfileImage
{
    public int Srno { get; set; }

    public string? Profilename { get; set; }

    public string? Imagename { get; set; }

    public int? Imageheight { get; set; }

    public int? Imagewidth { get; set; }

    public byte[]? Image { get; set; }

    public string? Imagetop { get; set; }

    public string? Imageleft { get; set; }
}
