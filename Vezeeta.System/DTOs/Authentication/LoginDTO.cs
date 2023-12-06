namespace Vezeeta.System.APIs.DTOs.Authentication
{
    public record LoginDTO
    {
        public string UserName { get; set; } = null!;
        public string Password { get; set; } = null!;
    }
}
