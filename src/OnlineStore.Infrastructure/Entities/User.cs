using System;
using System.Collections.Generic;

namespace OnlineStore.Infrastructure.Entities;

public partial class User
{
    public string Id { get; set; } = null!;

    public string Username { get; set; } = null!;
}
