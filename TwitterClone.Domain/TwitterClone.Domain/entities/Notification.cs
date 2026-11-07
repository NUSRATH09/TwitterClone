namespace TwitterClone.Domain.entities
{
    public abstract class Notification : BaseEntity
    {
        public Guid RecipientId { get; protected set; }

        public bool IsRead { get; private set; }

        public void MarkAsRead()
        {
            IsRead = true;
        }

        public abstract string GetMessage();
    }
}