using Application.DTOs.Registeration;
using AutoMapper;
using Domain.IdentityEntities;

namespace Application.Profiles.Identity
{
    public class UserMappingProfile : Profile
    {
        public UserMappingProfile()
        {
            CreateMap<ApplicationUser, UserDto>().ReverseMap();
            CreateMap<ApplicationUser, RegisterUserDto>().ReverseMap();
        }
    }
}
