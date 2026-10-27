namespace TwitterClone.Domain.entities;

public class Tweet
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public string Content { get; set; } = "";
    public DateTime CreatedAt { get; set; }
}