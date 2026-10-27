namespace TwitterClone.Domain.entities
{
    public class Follow : BaseEntity
    {
        public Guid FollowerId { get; set; }
        public Guid FollowingId { get; set; }
    }
}