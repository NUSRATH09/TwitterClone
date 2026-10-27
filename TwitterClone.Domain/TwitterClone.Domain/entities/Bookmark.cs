namespace TwitterClone.Domain.entities;

public class Bookmark
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public Guid TweetId { get; set; }
}