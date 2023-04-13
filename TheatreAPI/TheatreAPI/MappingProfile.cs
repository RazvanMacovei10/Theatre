using AutoMapper;
using TheatreAPI.DTOs;
using TheatreAPI.Models;

namespace TheatreAPI
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<RegisterFormDTO, RegisterForm>()
                .ForMember(dest => dest.Image, opt => opt.MapFrom(src=>Convert.FromBase64String(src.Image)));
            CreateMap<RegisterForm, RegisterFormDTO>()
                .ForMember(dest => dest.Image, opt => opt.MapFrom(src => Convert.ToBase64String(src.Image)));
            CreateMap<PlayDTO, Play>()
                .ForMember(dest => dest.Image, opt => opt.MapFrom(src => Convert.FromBase64String(src.Image)));
            CreateMap<Play, PlayDTO>()
                .ForMember(dest => dest.Image, opt => opt.MapFrom(src => Convert.ToBase64String(src.Image)));
            CreateMap<Event, EventSentDTO>()
                .ForMember(dest =>dest.TheatreName, opt => opt.MapFrom(src=> src.Theatre.User.Username));
            CreateMap<EventSentDTO, Event>();
            CreateMap<Event, EventDTO>()
                .ForMember(dest => dest.TheatreName, opt => opt.MapFrom(src => src.Theatre.User.Username));
            CreateMap<EventDTO, Event>();
        }
    }
}
