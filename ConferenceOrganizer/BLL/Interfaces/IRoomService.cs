using System.Threading.Tasks;
using BLL.Dtos;
using BLL.ViewModels;

namespace BLL.Interfaces
{
    public interface IRoomService
    {
        Task<EntityCreatedViewModel> CreateRoomAsync(RoomUpsertDto roomCreatedDto);

        Task<RoomsViewModel> GetAllRoomsAsync();

        Task<RoomViewModel> FindRoomByIdAsync(int roomId);

        Task UpdateRoomAsync(int roomId, RoomUpsertDto roomUpdateDto);

        Task DeleteRoomAsync(int roomId);
    }
}
