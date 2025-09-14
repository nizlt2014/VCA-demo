namespace ClaimsService.Application.DTOs
{
    public record CreateClaimDto(int ClaimNumber, int PolicyId, int CustomerId);
}
