namespace TwitterClone.Domain.entities
{
    public class Tweet : BaseEntity
    {
        public Guid UserId { get; set; }
        public string Content { get; set; } = "";
    }
}