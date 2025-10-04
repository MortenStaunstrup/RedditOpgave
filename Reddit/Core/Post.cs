namespace Core;

public class Post
{
    public long PostId { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public string Content { get; set; }
    public DateTime TimeStamp { get; set; }
    public List<Comment> Comments { get; set; } = new List<Comment>();
    public long Upvotes { get; set; }
    public long Downvotes { get; set; }
    
    
}