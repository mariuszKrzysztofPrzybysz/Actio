using System;

namespace Actio.Common.Events
{
    public class ActivityCreated : IAuthenticatedEvent
    {
        public ActivityCreated(Guid id, Guid userId, string name, string description, string category, DateTime createdAt)
        {
            Id = id;
            UserId = userId;
            Name = name;
            Description = description;
            Category = category;
            CreatedAt = createdAt;
        }

        protected ActivityCreated()
        {

        }

        public string Category { get; }
        public DateTime CreatedAt { get; }
        public string Description { get; }
        public Guid Id { get; }
        public string Name { get; }
        public Guid UserId { get; }
    }
}
