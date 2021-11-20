using BLL.Dtos;
using BLL.ViewModels;
using Domain.Entitites;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IUserService
    {
        Task<ApplicationUser> FindUserByIdAsync(int id);

        Task<UserViewModel> GetUserAsync(int userId);

        Task<DropDownViewModel> GetUsersDropDownAsync();

        Task UpdateProfessionalFieldsAsync(int userid, ProfessionalFieldUpdateDto fieldUpdateDto);

        Task<UsersViewModel> GetUsersAsync();
    }
}