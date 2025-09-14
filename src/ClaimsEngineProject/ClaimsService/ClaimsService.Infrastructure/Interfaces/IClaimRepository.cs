using ClaimsService.Domain;

namespace ClaimsService.Infrastructure.Interfaces
{
    public interface IClaimRepository
    {
        public Task<int> InsertClaimAsync(Claim claims);
        public Task<Claim?> GetByIdAsync(int id, CancellationToken ct = default);
    }
}
