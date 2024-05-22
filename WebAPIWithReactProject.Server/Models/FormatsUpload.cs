using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class FormatsUpload
{
    public int Srno { get; set; }

    public string? Formatname { get; set; }

    public int? Facilitycode { get; set; }

    public string? Filepath { get; set; }

    public int? Cid { get; set; }

    public string? Uploadedyn { get; set; }

    public DateTime? Uploadeddate { get; set; }
}
