namespace TwitterClone.Domain.entities
{
    public class Retweet : BaseEntity
    {
        public Guid UserId { get; set; }
        public Guid TweetId { get; set; }
    }
}