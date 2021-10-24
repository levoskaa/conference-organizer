using AutoMapper;
using BLL.ViewModels;
using Domain.Entitites;
using Domain.Entitites.Abstractions;

namespace BLL
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<EntityBase, EntityCreatedViewModel>();
            CreateMap<ApplicationUser, EntityCreatedViewModel>();
            CreateMap<Conference, ConferenceViewModel>()
                .ForMember(cvm => cvm.BeginDate, options => options.MapFrom(c => c.TimeFrame.BeginDate))
                .ForMember(cvm => cvm.EndDate, options => options.MapFrom(c => c.TimeFrame.EndDate));
        }
    }
}