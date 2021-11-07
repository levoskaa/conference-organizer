using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Entitites;

namespace Domain.Interfaces
{
    public interface IRoomRepository
    {
        int AddRoom(Room room);

        Task<Room> FindRoomByIdAsync(int roomId);

        void UpdateRoom(Room room);

        Task DeleteRoomAsync(int roomId);

        Task<IEnumerable<Room>> GetAllRoomsAsync();
    }
}
