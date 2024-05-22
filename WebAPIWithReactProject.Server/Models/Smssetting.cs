using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class Smssetting
{
    public int Srno { get; set; }

    public string? Username { get; set; }

    public string? Pass { get; set; }

    public string? Smstext { get; set; }

    public int Balance { get; set; }

    public string? SettingType { get; set; }

    public string? Smsonappointment { get; set; }

    public string? Empsms { get; set; }
}
