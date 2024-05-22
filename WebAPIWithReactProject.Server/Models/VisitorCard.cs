using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class VisitorCard
{
    public int Srno { get; set; }

    public string? Cardno { get; set; }

    public string? Pinexemptyn { get; set; }

    public int? Accesstype { get; set; }

    public string? Extendedyn { get; set; }

    public string? Pbexemptyn { get; set; }

    public string? Pincmdsyn { get; set; }

    public string? Accessgroups { get; set; }

    public string? Uploadedyn { get; set; }

    public string? Pin { get; set; }

    public string? Facilitycode { get; set; }

    public string? Compid { get; set; }

    public string? Locationid { get; set; }
}
