public class Comment
{
    public long CommentId { get; set; }
    public string Author { get; set; }
    public string Content { get; set; }
    public DateTime TimeStamp { get; set; }
    public long Upvotes { get; set; }
    public long Downvotes { get; set; }
}