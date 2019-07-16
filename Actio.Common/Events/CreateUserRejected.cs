namespace Actio.Common.Events
{
    public class CreateUserRejected : IRejectedEvent
    {
        public CreateUserRejected(string email, string code, string reason)
        {
            Email = email;
            Code = code;
            Reason = reason;
        }

        protected CreateUserRejected()
        {

        }

        public string Code { get; }
        public string Email { get; }
        public string Reason { get; }
    }
}
