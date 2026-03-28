namespace Sartor67.Models;

public class Product
{
    public int Id { get; set; }
    public string Category { get; set; } = "";
    public string Name { get; set; } = "";
    public string Price { get; set; } = "";
    public string Image { get; set; } = "";
    public string Description { get; set; } = "";
    public List<string> Sizes { get; set; } = new();
    public List<string> Details { get; set; } = new();
}