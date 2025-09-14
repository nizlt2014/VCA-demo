using AutoMapper;
using ClaimsService.Application.Abstraction;
using ClaimsService.Application.DTOs;
using ClaimsService.Domain;
using ClaimsService.Infrastructure.Interfaces;

namespace ClaimsService.Application.Implementation
{
    public class ClaimService : IClaimsService
    {
        private readonly IClaimRepository _claimRepository;
        private readonly IMapper _mapper;

        public ClaimService(IClaimRepository claimRepository, IMapper mapper)
        {
            _claimRepository = claimRepository;
            _mapper = mapper;
        }

        public async Task<int> CreateClaimAsync(CreateClaimDto claimDto)
        {
            var claim = _mapper.Map<Claim>(claimDto);
            return await _claimRepository.InsertClaimAsync(claim);
        }

        public async Task<CreateClaimDto?> GetByIdAsync(int id, CancellationToken ct = default)
        {
            return _mapper.Map<CreateClaimDto>(await _claimRepository.GetByIdAsync(id, ct));
        }
    }
}
