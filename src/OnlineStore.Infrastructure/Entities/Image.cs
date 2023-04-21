using System;
using System.Collections.Generic;

namespace OnlineStore.Infrastructure.Entities;

public partial class Image
{
    public string Id { get; set; } = null!;

    public string ProductId { get; set; } = null!;

    public string? Url { get; set; }

    public virtual Product Product { get; set; } = null!;
}
