﻿using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class Mastersgupload
{
    public int Srno { get; set; }

    public int? Sgid { get; set; }

    public int? Cid { get; set; }

    public string? Uploadedyn { get; set; }
}
