namespace Melody.BusinessLayer.Requests.Auth
{
    public class RegisterUserRequest
    {
        public Guid Uid { get; set; }

        public string Email { get; set; }

        public string DisplayName { get; set; }
    }
}
