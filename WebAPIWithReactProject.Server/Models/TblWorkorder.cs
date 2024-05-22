using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class TblWorkorder
{
    public int Id { get; set; }

    public string Workorderno { get; set; } = null!;

    public DateOnly FromDate { get; set; }

    public DateOnly ToDate { get; set; }

    public int Maxmanpower { get; set; }

    public int Vendorid { get; set; }

    public byte? Status { get; set; }

    public int? Addedby { get; set; }

    public DateOnly? Validityofwcp { get; set; }

    public DateOnly? Validityofll { get; set; }

    public byte? Closepoflag { get; set; }

    public string? Filepath { get; set; }

    public string? Eicid { get; set; }

    public string? Empid { get; set; }

    public DateTime? Closepodate { get; set; }
}
