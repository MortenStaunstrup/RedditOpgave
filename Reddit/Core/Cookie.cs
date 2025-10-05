namespace Core;

public class Cookie
{
    public string AuthorName { get; set; }
    public DateTime ExpirationDate { get; set; }
    public List<long> postsUpvoted { get; set; } = new List<long>();
    public List<long> postsDownvoted { get; set; } = new List<long>();
    public List<long> commentsUpvoted { get; set; } = new List<long>();
    public List<long> commentsDownvoted { get; set; } = new List<long>();
}