namespace Vezeeta.System.APIs.DTOs.Authentication
{
    public record RegisterDTO
    {
        //records are refrence immutable types
        //init=>once intialized it can never be changed=>can only be set during object initialization
        public string UserName { get; init; } = null!;
        public string Email { get; init; } = null!;
        public string Password { get; init; } = null!;
    }
}
