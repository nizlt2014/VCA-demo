using AutoMapper;
using UserService.Application.DTOs;
using UserService.Domain;
using UserService.Domain.Entities;

namespace UserService.Application.Mapping
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            //Map claimdto with claim of domain, CreatedAt field should be set as datetime.utcnow.
            CreateMap<CreateUserDto, User>()
//                .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => DateTime.UtcNow))
                .ReverseMap();
        }
    }
}
