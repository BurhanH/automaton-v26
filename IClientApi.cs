using Refit;

namespace AutomationV26;

public interface IClientApi
{
    [Get("/posts")]
    Task<HttpResponseMessage>GetPosts();
    
    [Get("/posts/{id}")]
    Task<HttpResponseMessage>GetPost(int id);
    
    [Get("/posts/{id}/comments")]
    Task<HttpResponseMessage>GetPostComments(int id);
    
    [Patch("/posts/{id}")]
    Task<HttpResponseMessage>PatchPost(int id);
    
    [Delete("/posts/{id}")]
    Task<HttpResponseMessage>DeletePost(int id);
}