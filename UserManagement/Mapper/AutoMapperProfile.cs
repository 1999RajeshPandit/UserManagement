using AutoMapper;
using UserManagement.Dtos;
using UserManagement.Models;

namespace UserManagement.Mapper
{
    public class AutoMapperProfile: Profile
    {
        public AutoMapperProfile() { 
            CreateMap<AppUser, CreateUserDto>().ReverseMap();
        }
    }
}
