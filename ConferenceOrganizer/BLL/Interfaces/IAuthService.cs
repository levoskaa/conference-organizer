using BLL.Dtos;
using BLL.ViewModels;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IAuthService
    {
        Task<TokenViewModel> LoginAsync(LoginDto loginDto);

        Task<EntityCreatedViewModel> CreateUserAsync(CreateUserDto createUserDto);
    }
}