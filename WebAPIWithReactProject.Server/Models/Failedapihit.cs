using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class Failedapihit
{
    public int Id { get; set; }

    public string? Url { get; set; }

    public string? Data { get; set; }

    public string? Lastresponse { get; set; }

    public string? Laststatuscode { get; set; }

    public DateTime? Lastattempttime { get; set; }

    public int? Attempts { get; set; }
}
