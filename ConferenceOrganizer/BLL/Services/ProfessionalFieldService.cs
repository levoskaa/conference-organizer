using System;
using System.Threading.Tasks;
using AutoMapper;
using BLL.Dtos;
using BLL.Interfaces;
using BLL.ViewModels;
using Domain.Entitites;
using Domain.Interfaces;

namespace BLL.Services
{
    public class ProfessionalFieldService : IProfessionalFieldService
    {
        private readonly IProfessionalFieldRepository professionalFieldRepository;
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public ProfessionalFieldService(
            IProfessionalFieldRepository professionalFieldRepository,
            IUnitOfWork unitOfWork,
            IMapper mapper
        )
        {
            this.mapper = mapper;
            this.professionalFieldRepository = professionalFieldRepository;
            this.unitOfWork = unitOfWork;
        }

        public async Task<EntityCreatedViewModel> CreateProfessionalFieldAsync(ProfessionalFieldUpsertDto professionalFieldCreatedDto)
        {
            var professionalField = mapper.Map<ProfessionalField>(professionalFieldCreatedDto);

            var id = professionalFieldRepository.AddProfessionalField(professionalField);
            await unitOfWork.SaveChangesAsync();
            return new EntityCreatedViewModel(id);
        }

        public async Task<ProfessionalFieldsViewModel> GetAllProfessionalFieldsAsync()
        {
            var professionalFields = await professionalFieldRepository.GetAllProfessionalFieldsAsync();
            var professionalFieldsViewModel = mapper.Map<ProfessionalFieldsViewModel>(professionalFields);
            return professionalFieldsViewModel;
        }

        public async Task<ProfessionalFieldViewModel> FindProfessionalFieldByIdAsync(int professionalFieldId)
        {
            var professionalField = await professionalFieldRepository.FindProfessionalFieldByIdAsync(professionalFieldId);
            var professionalFieldView = mapper.Map<ProfessionalFieldViewModel>(professionalField);
            return professionalFieldView;
        }

        public async Task UpdateProfessionalFieldAsync(int professionalFieldId, ProfessionalFieldUpsertDto professionalFieldUpdateDto)
        {
            var professionalField = await professionalFieldRepository.FindProfessionalFieldByIdAsync(professionalFieldId);
            professionalField.Update(mapper.Map<ProfessionalField>(professionalFieldUpdateDto));
            await unitOfWork.SaveChangesAsync();
        }

        public async Task DeleteProfessionalFieldAsync(int professionalFieldId)
        {
            await professionalFieldRepository.DeleteProfessionalFieldAsync(professionalFieldId);
            await unitOfWork.SaveChangesAsync();
        }
    }
}
