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
        }
    }
}