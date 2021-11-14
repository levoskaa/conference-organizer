using BLL.Dtos;
using Domain.Entitites;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IUserService
    {
        Task<ApplicationUser> FindUserByIdAsync(int id);

        Task UpdateProfessionalFields(int userid, ProfessionalFieldUpdateDto fieldUpdateDto);
    }
}