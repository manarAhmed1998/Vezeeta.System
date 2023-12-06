namespace Vezeeta.System.APIs.DTOs.Token
{
    public record TokenDTO
    {
        public string Token { get; init; } = null!;
        public DateTime ExpiryDate { get; init; }
    }
}
