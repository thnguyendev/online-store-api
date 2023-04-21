using System;
using System.Collections.Generic;

namespace OnlineStore.Infrastructure.Entities;

public partial class Product
{
    public string Id { get; set; } = null!;

    public string? Code { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public double? Price { get; set; }

    public virtual ICollection<Image> Images { get; set; } = new List<Image>();
}
