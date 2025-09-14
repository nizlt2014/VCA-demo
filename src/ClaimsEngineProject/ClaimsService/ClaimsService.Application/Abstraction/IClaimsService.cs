using ClaimsService.Application.DTOs;

namespace ClaimsService.Application.Abstraction
{
    public interface IClaimsService
    {
        public Task<int> CreateClaimAsync(CreateClaimDto claim);
        public Task<CreateClaimDto?> GetByIdAsync(int id, CancellationToken ct = default);
    }
}
