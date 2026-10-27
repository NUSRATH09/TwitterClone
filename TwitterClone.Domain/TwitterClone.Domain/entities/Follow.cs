

namespace TwitterClone.Domain.entities;

public class Follow
{
    public Guid Id { get; set; }
    public Guid FollowerId { get; set; }
    public Guid FollowingId { get; set; }
}