namespace TwitterClone.Domain.entities
{
    public class Notification : BaseEntity
    {
        public Guid UserId { get; set; }
        public string Type { get; set; } = "";
        public bool IsRead { get; set; }
    }
}