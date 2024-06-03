namespace SoftwareCenterApi.Catalog.Data;

public class CatalogItem
{
    public Guid Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
}