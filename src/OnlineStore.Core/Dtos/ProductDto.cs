namespace OnlineStore.Core.Dtos
{
    public class ProductDto
    {
        public string Id { get; set; } = string.Empty;
        public string? Code { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public double? Price { get; set; }
        public IEnumerable<string?>? ImageUrls { get; set; }
    }
}
