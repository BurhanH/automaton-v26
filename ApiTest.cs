using System.Net;
using Refit;
using System.Text.Json;

namespace AutomationV26;

public class ApiTest
{
    private readonly IClientApi _clientApi;
    
    public ApiTest()
    {
        _clientApi = RestService.For<IClientApi>("https://jsonplaceholder.typicode.com");
    }
    
    [Fact]
    public async Task GetPostsTest()
    {
        // Arrange
        
        // Act
        var response = await _clientApi.GetPosts();
        
        // Assert
        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        Assert.NotNull(response.Content);
        
        var jsonString = await response.Content.ReadAsStringAsync();
        Assert.NotEmpty(jsonString);
        
        var posts = JsonSerializer.Deserialize<List<PostResponse>>(jsonString);
        Assert.NotNull(posts);
        Assert.NotEmpty(posts);
        Assert.True(posts.Count > 0);
        Assert.Equal(100, posts.Count);
    }
}