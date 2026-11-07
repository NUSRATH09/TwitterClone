namespace TwitterClone.Domain.entities
{
    public class LikeNotification : Notification
    {
        public Guid LikedByUserId { get; set; }

        public Guid TweetId { get; set; }

        public override string GetMessage()
        {
            return "Someone liked your tweet.";
        }
    }
}