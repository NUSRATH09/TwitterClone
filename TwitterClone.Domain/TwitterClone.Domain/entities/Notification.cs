
using System;

namespace TwitterClone.Domain.entities
{
    public class Notification : BaseEntity
    {
        public string Message { get; set; } = "";
        public bool IsRead { get; set; } = false;

        public Notification(string message)
        {
            Message = message;
        }
    }
}
