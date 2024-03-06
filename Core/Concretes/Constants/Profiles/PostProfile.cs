using AutoMapper;
using Core.Concretes.DTOs;
using Core.Concretes.Entities;

namespace Core.Concretes.Constants.Profiles
{
    public class PostProfile : Profile
    {
        public PostProfile()
        {
            CreateMap<Post, PostDetail>()
                .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Category.Title))
                .ForMember(dest => dest.Tags, opt => opt.MapFrom(src => src.Tags.Select(x => x.Title).ToArray()));

            CreateMap<Post, PostListItem>()
                .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Category.Title))
                .ForMember(dest => dest.Tags, opt => opt.MapFrom(src => src.Tags.Select(x => x.Title).ToArray()));
        }
    }
}
