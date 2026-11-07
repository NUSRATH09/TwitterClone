namespace TwitterClone.Domain.entities
{
    public class CommentNotification : Notification
    {
        public Guid CommentedByUserId { get; set; }

        public Guid TweetId { get; set; }

        public string Comment { get; set; } = "";

        public override string GetMessage()
        {
            return "Someone commented: " + Comment;
        }
    }
}