using System.Net.Http.Json;
using Core;

namespace Frontend.Service;

public class PostService
{
    HttpClient Client;

    public PostService(HttpClient httpClient)
    {
        Client = httpClient;
    }


    public async Task<HttpResponseMessage> GetPosts(int page)
    {
        return await Client.GetAsync($"{page}/posts");
    }

    public async Task<HttpResponseMessage> GetPost(long id)
    {
        return await Client.GetAsync($"posts/{id}");
    }

    public async Task<HttpResponseMessage> UpvotePost(long id)
    {
        return await Client.PutAsync($"posts/{id}/upvote", new StringContent(string.Empty));
    }

    public async Task<HttpResponseMessage> RemoveUpvotePost(long id)
    {
        return await Client.PutAsync($"posts/{id}/upvote/remove", new StringContent(string.Empty));
    }
    
    public async Task<HttpResponseMessage> DownvotePost(long id)
    {
        return await Client.PutAsync($"posts/{id}/downvote", new StringContent(string.Empty));
    }
    
    public async Task<HttpResponseMessage> RemoveDownvotePost(long id)
    {
        return await Client.PutAsync($"posts/{id}/downvote/remove", new StringContent(string.Empty));
    }

    public async Task<HttpResponseMessage> UpvoteComment(long postId, long commentId)
    {
        return await Client.PutAsync($"posts/{postId}/comments/{commentId}/upvote",  new StringContent(string.Empty));
    }
    
    public async Task<HttpResponseMessage> RemoveUpvoteComment(long postId, long commentId)
    {
        return await Client.PutAsync($"posts/{postId}/comments/{commentId}/upvote/remove", new StringContent(string.Empty));
    }
    
    public async Task<HttpResponseMessage> DownvoteComment(long postId, long commentId)
    {
        return await Client.PutAsync($"posts/{postId}/comments/{commentId}/downvote",  new StringContent(string.Empty));
    }
    
    public async Task<HttpResponseMessage> RemoveDownvoteComment(long postId, long commentId)
    {
        return await Client.PutAsync($"posts/{postId}/comments/{commentId}/downvote/remove", new StringContent(string.Empty));
    }

    public async Task<HttpResponseMessage> PostPost(PostDTO post)
    {
        return await Client.PostAsJsonAsync($"posts", post);
    }

    public async Task<HttpResponseMessage> PostComment(long postId,  CommentDTO comment)
    {
        return await Client.PostAsJsonAsync($"posts/{postId}/comments", comment);
    }
}