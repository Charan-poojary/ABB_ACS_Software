using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class Reportsetting
{
    public int Srno { get; set; }

    public string? Reportname { get; set; }

    public string? Extension { get; set; }

    public string? Formatstring { get; set; }

    public string? Fieldseparator { get; set; }

    public string? Rowterminator { get; set; }

    public int? Fieldcount { get; set; }

    public int? Rowcount { get; set; }

    public string? Showheader { get; set; }

    public string? Flag { get; set; }

    public string? Notes { get; set; }

    public string? Reporttype { get; set; }

    public string? Dateformat { get; set; }

    public string? Notes1 { get; set; }

    public string? Dateseparator { get; set; }

    public string? Columnstring { get; set; }

    public byte? Usertype { get; set; }
}
