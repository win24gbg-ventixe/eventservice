using System.ComponentModel.DataAnnotations;

namespace Presentation.Data;

public class EventEntity
{
    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Title { get; set; } = null!;
    public string Location { get; set; } = null!;
    public DateTime Date { get; set; }
    public TimeSpan Time { get; set; }
    public decimal Price { get; set; }
    public string Category { get; set; } = null!;
    public string Description { get; set; } = null!;
}
