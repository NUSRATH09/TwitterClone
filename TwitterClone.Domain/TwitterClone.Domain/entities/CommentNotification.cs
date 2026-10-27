namespace TwitterClone.Domain.entities
{
    public class CommentNotification : BaseEntity
    {
        public Guid UserId { get; set; }
        public Guid CommentedByUserId { get; set; }
        public Guid TweetId { get; set; }
        public bool IsRead { get; set; }
    }
}