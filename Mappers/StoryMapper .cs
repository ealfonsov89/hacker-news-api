using HackerNewsApi.Models;

namespace HackerNewsApi.Mappers;

public static class StoryMapper
{
    public static Story Map(StoryDto storyDto)
    {
        return new Story
        {
            Id = storyDto.Id,
            Title = storyDto.Title,
            Url = storyDto.Url,
            By = storyDto.By,
            Score = storyDto.Score,
            Time = new DateTime(storyDto.Time),
            CommentCount = storyDto.Kids.Count()
        };
    }
}