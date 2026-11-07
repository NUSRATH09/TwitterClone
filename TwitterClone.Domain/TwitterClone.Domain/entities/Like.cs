namespace TwitterClone.Domain.entities
{
    public class Like : BaseEntity
    {
        public Guid UserId { get; set; }
        public Guid TweetId { get; set; }
    }
}