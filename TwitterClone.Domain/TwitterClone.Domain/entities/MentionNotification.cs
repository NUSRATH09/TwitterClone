namespace TwitterClone.Domain.entities
{
    public class MentionNotification : Notification
    {
        public Guid MentionedByUserId { get; set; }

        public Guid TweetId { get; set; }

        public override string GetMessage()
        {
            return "You were mentioned in a tweet.";
        }
    }
}