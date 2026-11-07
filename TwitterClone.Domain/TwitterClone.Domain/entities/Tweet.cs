
using System;

namespace TwitterClone.Domain.entities
{
    public class Tweet : BaseEntity
    {
        public Guid UserId { get; set; }

        public string Content { get; set; } = "";

        public int LikeCount { get; set; } = 0;

        public int RetweetCount { get; set; } = 0;
    }
}
