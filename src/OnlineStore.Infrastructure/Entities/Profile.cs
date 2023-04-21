using System;
using System.Collections.Generic;

namespace OnlineStore.Infrastructure.Entities;

public partial class Profile
{
    public string Id { get; set; } = null!;

    public string? Address { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }
}
