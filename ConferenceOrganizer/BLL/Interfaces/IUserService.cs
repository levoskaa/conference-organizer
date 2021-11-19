using BLL.Dtos;
using BLL.ViewModels;
using Domain.Entitites;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IUserService
    {
        Task<ApplicationUser> FindUserByIdAsync(int id);

        Task<UserViewModel> GetUser(int userId);

        Task UpdateProfessionalFields(int userid, ProfessionalFieldUpdateDto fieldUpdateDto);
    }
}