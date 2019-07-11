using System;

namespace Actio.Common.Commands
{
    public class CreateActivity : IAuthenticatedCommand
    {
        public string Category { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid UserId { get; set; }
    }
}