namespace ClaimsService.Domain
{
    public class Claim
    {
        public int ClaimId { get; set; }
        public int ClaimNumber { get; set; }
        public int PolicyId { get; set; }
        public int CustomerId { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
