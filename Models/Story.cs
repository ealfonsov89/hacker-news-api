using System.Text.Json.Serialization;

namespace HackerNewsApi.Models;

public class Story
{
    [JsonPropertyName("id")]
    public int Id { get; set; }
    [JsonPropertyName("title")]
    public required string Title { get; set; }
    [JsonPropertyName("uri")]
    public required string Url { get; set; }
    [JsonPropertyName("postedBy")]
    public required string By { get; set; }
    [JsonPropertyName("score")]
    public int Score { get; set; }
    [JsonPropertyName("time")]
    public DateTime Time { get; set; }
    public int CommentCount { get; set; }

}