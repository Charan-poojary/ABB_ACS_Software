using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class Backupsetting
{
    public int Srno { get; set; }

    public string? Backuptype { get; set; }

    public string? Backuppath { get; set; }

    public int? Day { get; set; }

    public string? Time { get; set; }

    public string? Bknotes { get; set; }

    public string? Bknotes1 { get; set; }

    public string? Bknotes2 { get; set; }

    public string? Bknotes3 { get; set; }

    public string? Setflag { get; set; }
}
