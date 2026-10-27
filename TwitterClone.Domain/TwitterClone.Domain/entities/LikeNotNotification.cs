namespace TwitterClone.Domain.entities
{
    public class LikeNotification : BaseEntity
    {
        public Guid UserId { get; set; }
        public Guid LikedByUserId { get; set; }
        public Guid TweetId { get; set; }
        public bool IsRead { get; set; }
    }
}