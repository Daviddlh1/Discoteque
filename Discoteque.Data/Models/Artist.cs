namespace Discoteque.Data.Models;

public class Artist : BaseEntity<int>
{
    public string Name { get; set; } = "";
    public string Label { get; set; } = "";
    public bool IsOntour { get; set; }
}