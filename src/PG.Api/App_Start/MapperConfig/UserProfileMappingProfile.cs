using AutoMapper;
using PG.Api.Domains.UserProfile;
using PG.Model;

namespace PG.Api
{
    public class UserProfileMappingProfile : Profile
    {
        public UserProfileMappingProfile()
        {
            CreateMap<EditUserProfileDto, UserProfile>();
            CreateMap<UserProfileDto, UserProfile>().ReverseMap();
        }
    }
}