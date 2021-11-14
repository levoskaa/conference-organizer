using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.Dtos;
using BLL.Interfaces;
using BLL.Services;
using BLL.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Web.Common;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    public class RoomsController : ApiController
    {
        private readonly IRoomService roomService;

        public RoomsController(IRoomService roomService)
        {
            this.roomService = roomService;
        }

        [HttpPost]
        [Authorize("Admin")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public Task<EntityCreatedViewModel> CreateRoom([FromBody] RoomUpsertDto roomCreateDto)
        {
            HttpContext.Response.StatusCode = StatusCodes.Status201Created;
            return roomService.CreateRoomAsync(roomCreateDto);
        }

        [HttpGet]
        public Task<RoomsViewModel> GetRooms()
        {
            return roomService.GetAllRoomsAsync();
        }

        [HttpGet("{roomId}")]
        public Task<RoomViewModel> GetRoomById([FromRoute] int roomId)
        {
            return roomService.FindRoomByIdAsync(roomId);
        }

        [HttpPut("{roomId}")]
        [Authorize("Admin")]
        public Task UpdateRoom([FromRoute] int roomId, [FromBody] RoomUpsertDto roomUpdateDto)
        {
            return roomService.UpdateRoomAsync(roomId, roomUpdateDto);
        }

        [HttpDelete("{roomId}")]
        [Authorize("Admin")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public Task DeleteRoom([FromRoute] int roomId)
        {
            HttpContext.Response.StatusCode = StatusCodes.Status204NoContent;
            return roomService.DeleteRoomAsync(roomId);
        }
    }
}
