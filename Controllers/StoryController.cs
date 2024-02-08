using HackerNewsApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace HackerNewsApi.Controllers;

[ApiController]
[Route("[controller]")]
public class StoryController : ControllerBase
{
    private readonly StoriesService _storiesService;
    public StoryController(StoriesService storiesService)
    {
        _storiesService = storiesService;
    }

    [HttpGet]
    public async Task<IActionResult> GetBestStories(int limit = 10)
    {
        try {
            var stories = await _storiesService.GetBestStories(limit);
            return Ok(stories);
        } catch (Exception ex) {
            return BadRequest(ex.Message);
        }
    }
}
