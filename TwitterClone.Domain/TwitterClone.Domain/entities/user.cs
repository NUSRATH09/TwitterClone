
using System;
using System.Collections.Generic;

namespace TwitterClone.Domain.entities
{
    public class User : BaseEntity, IFollowable, INotifable
    {
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public string Email { get; set; } = "";

        public List<Guid> Followers { get; set; } = new List<Guid>();

        public List<Notification> Notifications { get; set; }
            = new List<Notification>();

        public void Follow(Guid id)
        {
            if (!Followers.Contains(id))
            {
                Followers.Add(id);
            }
        }

        public void UnFollow(Guid id)
        {
            Followers.Remove(id);
        }

        public void AddNotify(Notification notification)
        {
            Notifications.Add(notification);
        }
    }
}
