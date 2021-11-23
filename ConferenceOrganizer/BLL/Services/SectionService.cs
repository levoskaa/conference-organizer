using System.Globalization;
using System.IO;
using System.Linq;
using AutoMapper;
using BLL.Dtos;
using BLL.Interfaces;
using BLL.ViewModels;
using Domain.Entitites;
using Domain.Interfaces;
using System.Threading.Tasks;
using BLL.Exceptions;
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

        public async Task AddPresentationAsync(int sectionId, PresentationUpsertDto presentationUpsertDto)
        {
          var section = await sectionRepository.FindSectionByIdAsync(sectionId);

          var presentation = mapper.Map<Presentation>(presentationUpsertDto); 
          section.AddPresentation(presentation);

          await unitOfWork.SaveChangesAsync();
        }

        public async Task AddPresentationsByFileAsync(int sectionId, IFormFile presentationsFile)
        {
          var section = await sectionRepository.FindSectionByIdAsync(sectionId);
      
          using (var reader = new StreamReader(presentationsFile.OpenReadStream()))
          using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
          {
            var presentationDtos = csv.GetRecords<PresentationUpsertDto>().ToList();

            foreach (var presentationDto in presentationDtos)
            {
              var presentation = mapper.Map<Presentation>(presentationDto);
              presentation.Section = section;
              presentation.SectionId = section.Id;
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

        public async Task<PresentationsViewModel> GetAllSectionPresentationsAsync(int sectionId)
        {
          var section = await sectionRepository.FindSectionByIdAsync(sectionId);
          var presentationsViewModel = mapper.Map<PresentationsViewModel>(section.Presentations);
          return presentationsViewModel;
        }

        public async Task<ConferenceViewModel> GetSectionConferenceAsync(int sectionId)
        {
          var section = await sectionRepository.FindSectionByIdAsync(sectionId);
          var conferenceViewModel = mapper.Map<ConferenceViewModel>(section.Conference);
          return conferenceViewModel;
        }

        public async Task<ProfessionalFieldViewModel> GetSectionFieldAsync(int sectionId)
        {
          var section = await sectionRepository.FindSectionByIdAsync(sectionId);
          var fieldViewModel = mapper.Map<ProfessionalFieldViewModel>(section.Field);
          return fieldViewModel;
    }

        public async Task<UserViewModel> GetSectionChairmanAsync(int sectionId)
        {
          var section = await sectionRepository.FindSectionByIdAsync(sectionId);
          var userViewModel = await userService.GetUserAsync(section.ChairmanId);
          return userViewModel;
    }

        public async Task<RoomViewModel> GetSectionRoomAsync(int sectionId)
        {
          var section = await sectionRepository.FindSectionByIdAsync(sectionId);
          var roomViewModel = mapper.Map<RoomViewModel>(section.Room);
          return roomViewModel;
    }
    }
}