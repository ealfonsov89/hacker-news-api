
namespace HackerNewsApi.Services;
using System.Linq;

using Firebase.Database;
using Firebase.Database.Query;
using HackerNewsApi.Mappers;
using HackerNewsApi.Models;

public class StoriesService
{
    private readonly FirebaseClient _firebaseClient;
    public StoriesService(FirebaseClient firebaseClient)
    {
        _firebaseClient = firebaseClient;
    }

    public async Task<Story> GetStoryDetails(int id)
    {
        var storyDto = await _firebaseClient
            .Child("item")
            .Child(id.ToString())
            .OnceSingleAsync<StoryDto>();
            
        var story = StoryMapper.Map(storyDto);

        return story;
    }

    public async Task<Story[]>  GetBestStories(int limit)
    {
        var bestStories = await _firebaseClient
            .Child("beststories")
            .OrderByKey()
            .LimitToFirst(limit)
            .OnceSingleAsync<int[]>();

        var bestStoriesDetailTasks = bestStories.Select(GetStoryDetails);
        var bestStoriesDetail = await Task.WhenAll(bestStoriesDetailTasks);

        return bestStoriesDetail;
    }
}