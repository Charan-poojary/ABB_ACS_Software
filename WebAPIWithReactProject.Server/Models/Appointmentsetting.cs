using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class Appointmentsetting
{
    public int Srno { get; set; }

    public string? AdminApproval { get; set; }

    public string? SmstoVisitor { get; set; }

    public string? SmstoEmployee { get; set; }
}
