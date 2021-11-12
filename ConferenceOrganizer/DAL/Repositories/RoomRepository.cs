using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Entitites;
using Domain.Exceptions;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories
{
    public class RoomRepository : IRoomRepository
    {
        private readonly ApplicationDbContext dbContext;

        public RoomRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public int AddRoom(Room room)
        {
            dbContext.Rooms.Add(room);
            return room.Id;
        }

        public async Task<Room> FindRoomByIdAsync(int roomId)
        {
            var room = await dbContext.Rooms
                .FirstOrDefaultAsync(c => c.Id == roomId);
            if (room == null)
            {
                throw new EntityNotFoundException($"Room with id {roomId} not found.");
            }
            return room;
        }

        public void UpdateRoom(Room room)
        {
            dbContext.Rooms.Update(room);

        }

        public async Task DeleteRoomAsync(int roomId)
        {
            var room = await dbContext.Rooms.FindAsync(roomId);
            if (room != null)
            {
                dbContext.Rooms.Remove(room);
            }
        }

        public async Task<IEnumerable<Room>> GetAllRoomsAsync()
        {
            var rooms = await dbContext.Rooms.ToListAsync();
            return rooms;
        }
    }
}
