﻿using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class Cardstounregister
{
    public int Srno { get; set; }

    public int? Empid { get; set; }

    public int? Cid { get; set; }

    public DateTime? Dates { get; set; }
}
