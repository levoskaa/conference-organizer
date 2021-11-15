using System.Globalization;
using System.IO;
using AutoMapper;
using BLL.Dtos;
using BLL.Interfaces;
using BLL.ViewModels;
using Domain.Entitites;
using Domain.Interfaces;
using System.Threading.Tasks;
using CsvHelper;
using Microsoft.AspNetCore.Http;

namespace BLL.Services
{
    public class SectionService : ISectionService
    {
        private readonly ISectionRepository sectionRepository;
        private readonly IRoomRepository roomRepository;
        private readonly IProfessionalFieldRepository fieldRepository;
        private readonly IUserService userService;
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;

        public SectionService(
            ISectionRepository sectionRepository,
            IRoomRepository roomRepository,
            IProfessionalFieldRepository fieldRepository,
            IUserService userService,
            IMapper mapper,
            IUnitOfWork unitOfWork)
        {
            this.sectionRepository = sectionRepository;
            this.roomRepository = roomRepository;
            this.fieldRepository = fieldRepository;
            this.userService = userService;
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
        }

        public async Task<SectionViewModel> FindSectionByIdAsync(int sectionId)
        {
            var section = await sectionRepository.FindSectionByIdAsync(sectionId);
            var sectionViewModel = mapper.Map<SectionViewModel>(section);
            return sectionViewModel;
        }

        public async Task AddPresentationsAsync(int sectionId, PresentationsUpsertDto presentationsUpsertDto)
        {
            var section = await sectionRepository.FindSectionByIdAsync(sectionId);

            foreach (var presentationUpsertDto in presentationsUpsertDto.Presentations)
            {
                var presentation = mapper.Map<Presentation>(presentationUpsertDto);
                section.AddPresentation(presentation);
            }

            await unitOfWork.SaveChangesAsync();
        }

        public async Task AddPresentationsByFileAsync(int sectionId, IFormFile presentationsFile)
        {
          var section = await sectionRepository.FindSectionByIdAsync(sectionId);

          using (var reader = new StreamReader(presentationsFile.OpenReadStream()))
          using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
          {
            var presentations = csv.GetRecords<PresentationUpsertDto>();
            foreach (var presentationDto in presentations)
            {
              var presentation = mapper.Map<Presentation>(presentationDto);
              section.AddPresentation(presentation);
            }
          }

          await unitOfWork.SaveChangesAsync();
        }

        public async Task UpdateSectionAsync(int sectionId, SectionUpsertDto sectionUpdateDto)
        {
            var section = await sectionRepository.FindSectionByIdAsync(sectionId);
            var timeFrame = new TimeFrame(sectionUpdateDto.BeginDate, sectionUpdateDto.EndDate);
            var room = await roomRepository.FindRoomByIdAsync(sectionUpdateDto.RoomId);
            var chairman = await userService.FindUserByIdAsync(sectionUpdateDto.ChairmanId);
            var field = await fieldRepository.FindProfessionalFieldByIdAsync(sectionUpdateDto.FieldId);
            section.Update(timeFrame, room, chairman, field);
            await unitOfWork.SaveChangesAsync();
        }

        public async Task DeleteSectionAsync(int sectionId)
        {
            await sectionRepository.DeleteSectionAsync(sectionId);
            await unitOfWork.SaveChangesAsync();
        }
    }
}