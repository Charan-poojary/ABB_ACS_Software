using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class EventMaster
{
    public string EventId { get; set; } = null!;

    public string? Description { get; set; }

    public string? Taskcode { get; set; }

    public string? Eventcode { get; set; }

    public string? Classcode { get; set; }
}
