﻿using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class AdminTable
{
    public int AdminId { get; set; }

    public string AdminName { get; set; } = null!;

    public string AdminEmail { get; set; } = null!;

    public string AdminDepartment { get; set; } = null!;

    public string AdminPhone { get; set; } = null!;

    public string AdminPassword { get; set; } = null!;


}
