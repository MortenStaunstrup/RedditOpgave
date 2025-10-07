using System.ComponentModel.DataAnnotations;

namespace Core;

public class Post
{
    public long PostId { get; set; }
    [Required]
    [MaxLength(400)]
    public string Title { get; set; }
    public string Author { get; set; }
    [MaxLength(800)]
    public string? Content { get; set; }
    public string? URL { get; set; }
    public DateTime TimeStamp { get; set; }
    public List<Comment> Comments { get; set; } = new List<Comment>();
    public long Upvotes { get; set; }
    public long Downvotes { get; set; }
    
    
}