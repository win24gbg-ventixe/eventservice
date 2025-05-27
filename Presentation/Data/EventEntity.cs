namespace Presentation.Data;

public class EventEntity
{
    public int Id { get; set; }
    public string Title { get; set; } = null!;
    public string Location { get; set; } = null!;
    public DateTime Date { get; set; }
    public TimeSpan Time { get; set; }
    public decimal Price { get; set; }
    public string Category { get; set; } = null!;
    public int PercentageBooked { get; set; }
}
