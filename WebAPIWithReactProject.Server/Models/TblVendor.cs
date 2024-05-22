using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class TblVendor
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Addedby { get; set; } = null!;

    public string? Password { get; set; }
}
