namespace Vezeeta.System.APIs.DTOs.Authentication
{
    public record RegisterDTO
    {
        //once intialized it can never be changed
        public string UserName { get; init; } = null!;
        public string Email { get; init; } = null!;
        public string Password { get; init; } = null!;
    }
}
