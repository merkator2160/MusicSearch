using AutoMapper;
using MusicSearch.Api.Models;
using MusicSearch.Services.Models;

namespace MusicSearch.Core.AutoMapper.Profiles
{
	public class AlbumProfile : Profile
    {
        public AlbumProfile()
        {
			CreateMap<SearchResponseItem, AlbumDto>();


			//CreateMap<UserDto, UserDb>()
			//    .ForMember(from => from.UserRoles, opt => opt.Ignore())
			//    .ForMember(dest => dest.RefreshToken, opt => opt.Ignore())
			//    .ReverseMap()
			//    .ForMember(dest => dest.Roles, opt => opt.MapFrom(src => src.UserRoles.Select(p => p.Role.RoleName)));
			//CreateMap<UserDto, UserAm>()
			//    .ReverseMap();
			//CreateMap<RegisterUserAm, UserDto>()
			//    .ForMember(from => from.Id, opt => opt.Ignore())
			//    .ForMember(from => from.Roles, opt => opt.Ignore());
		}
	}
}