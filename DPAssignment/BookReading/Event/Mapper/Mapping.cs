using AutoMapper;
using Event.Models.ViewModels;
using CommonModel.Model;

namespace Event.MappingProfiles
{
    public class EventMappingProfile : Profile
    {
        public EventMappingProfile()
        {
            CreateMap<AddEvent, EditEventViewModel>();
        }
    }
}
