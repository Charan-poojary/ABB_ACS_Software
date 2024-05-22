using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class Masterdsg
{
    public int Srno { get; set; }

    public int? Cid { get; set; }

    public int? Doorno { get; set; }

    public string? Doorname { get; set; }

    public string? Name { get; set; }

    public int? Timezone { get; set; }

    public int? Holidaygroup { get; set; }

    public string? Macaddr { get; set; }

    public string? Doorstatus { get; set; }
}
