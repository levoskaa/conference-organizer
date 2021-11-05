using AutoMapper;
using BLL.Dtos;
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
                .ForMember(cvm => cvm.Conferences, options => options.MapFrom(x => x));
            CreateMap<ConferenceUpsertDto, Conference>()
                .ForMember(c => c.TimeFrame, options => options.MapFrom(dto => new TimeFrame(dto.BeginDate, dto.EndDate)));

            CreateMap<Section, SectionViewModel>()
                .ForMember(svm => svm.BeginDate, options => options.MapFrom(s => s.TimeFrame.BeginDate))
                .ForMember(svm => svm.EndDate, options => options.MapFrom(s => s.TimeFrame.EndDate))
                .ForMember(svm => svm.Room, options => options.MapFrom(s => s.Room.UniqueName))
                .ForMember(svm => svm.Chairman, options => options.MapFrom(s => s.User.UserName))
                .ForMember(svm => svm.Field, options => options.MapFrom(s => s.Field.Name));
            CreateMap<IEnumerable<Section>, SectionsViewModel>()
                .ForMember(svm => svm.Sections, options => options.MapFrom(x => x));
            CreateMap<SectionUpsertDto, Section>()
                .ForMember(s => s.TimeFrame,
                    options => options.MapFrom(dto => new TimeFrame(dto.BeginDate, dto.EndDate)))
                .ForMember(s => s.Room.UniqueName, options => options.MapFrom(dto => dto.Room))
                .ForMember(s => s.Field.Name, options => options.MapFrom(dto => dto.Field))
                .ForMember(s => s.User.UserName, options => options.MapFrom(dto => dto.Chairman));
        }
    }
}