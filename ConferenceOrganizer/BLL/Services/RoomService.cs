using AutoMapper;
using BLL.Dtos;
using BLL.Interfaces;
using BLL.ViewModels;
using Domain.Entitites;
using Domain.Interfaces;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class RoomService : IRoomService
    {
        private readonly IRoomRepository roomRepository;
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public RoomService(
            IRoomRepository roomRepository,
            IUnitOfWork unitOfWork,
            IMapper mapper
            )
        {
            this.mapper = mapper;
            this.roomRepository = roomRepository;
            this.unitOfWork = unitOfWork;
        }

        public async Task<EntityCreatedViewModel> CreateRoomAsync(RoomUpsertDto roomCreatedDto)
        {
            var room = mapper.Map<Room>(roomCreatedDto);

            var id = roomRepository.AddRoom(room);
            await unitOfWork.SaveChangesAsync();
            return new EntityCreatedViewModel(id);
        }

        public async Task<RoomsViewModel> GetAllRoomsAsync()
        {
            var rooms = await roomRepository.GetAllRoomsAsync();
            var roomsViewModel = mapper.Map<RoomsViewModel>(rooms);
            return roomsViewModel;
        }

        public async Task<RoomViewModel> FindRoomByIdAsync(int roomId)
        {
            var room = await roomRepository.FindRoomByIdAsync(roomId);
            var roomViewModel = mapper.Map<RoomViewModel>(room);
            return roomViewModel;
        }

        public async Task UpdateRoomAsync(int roomId, RoomUpsertDto roomUpdateDto)
        {
            var room = await roomRepository.FindRoomByIdAsync(roomId);
            room.Update(mapper.Map<Room>(roomUpdateDto));
            await unitOfWork.SaveChangesAsync();
        }

        public async Task DeleteRoomAsync(int roomId)
        {
            await roomRepository.DeleteRoomAsync(roomId);
            await unitOfWork.SaveChangesAsync();
        }
    }
}