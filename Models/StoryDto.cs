public class StoryDto
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public required string Url { get; set; }
    public required string By { get; set; }
    public int Score { get; set; }
    public required IEnumerable<int> Kids { get; set; }
    public int Time { get; set; }
}