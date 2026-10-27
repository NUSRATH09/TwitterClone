namespace TwitterClone.Domain.entities
{
    public class Bookmark : BaseEntity
    {
        public Guid UserId { get; set; }
        public Guid TweetId { get; set; }
    }
}