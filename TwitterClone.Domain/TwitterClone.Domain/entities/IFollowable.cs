
using System;

namespace TwitterClone.Domain.entities
{
    public interface IFollowable
    {
        void Follow(Guid id);
        void UnFollow(Guid id);
    }
}
