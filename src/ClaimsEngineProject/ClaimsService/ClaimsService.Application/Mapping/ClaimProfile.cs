using AutoMapper;
using ClaimsService.Application.DTOs;
using ClaimsService.Domain;

namespace ClaimsService.Application.Mapping
{
    public class ClaimProfile : Profile
    {
        public ClaimProfile()
        {
            //Map claimdto with claim of domain, CreatedAt field should be set as datetime.utcnow.
            CreateMap<CreateClaimDto, Claim>()
                .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => DateTime.UtcNow))
                .ReverseMap();
        }
    }
}
