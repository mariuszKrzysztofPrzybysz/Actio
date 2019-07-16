using System;

namespace Actio.Common.Events
{
    public class UserCreated : IAuthenticatedEvent
    {
        public UserCreated(Guid userId, string email, string name)
        {
            UserId = userId;
            Email = email;
            Name = name;
        }

        protected UserCreated()
        {

        }

        public string Email { get; }
        public string Name { get; }
        public Guid UserId { get; }
    }
}
