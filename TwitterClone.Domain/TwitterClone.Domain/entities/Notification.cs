
namespace TwitterClone.Domain.entities;

public class Notification
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public string Type { get; set; } = "";
    public bool IsRead { get; set; }
}