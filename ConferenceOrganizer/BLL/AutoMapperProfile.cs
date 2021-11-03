using AutoMapper;
using BLL.ViewModels;
using Domain.Entitites;
using Domain.Entitites.Abstractions;
using System.Collections.Generic;

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
            CreateMap<IEnumerable<Conference>, ConferencesViewModel>()
                .ForMember(cvm => cvm.Conferences, options => options.MapFrom(c => c));
        }
    }
}