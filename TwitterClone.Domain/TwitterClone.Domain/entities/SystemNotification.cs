namespace TwitterClone.Domain.entities
{
    public class SystemNotification : Notification
    {
        public string Message { get; set; } = "";

        public override string GetMessage()
        {
            return Message;
        }
    }
}