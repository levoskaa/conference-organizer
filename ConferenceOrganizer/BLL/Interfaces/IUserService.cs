using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entitites;

namespace BLL.Interfaces
{
    public interface IUserService
    {
        Task<ApplicationUser> FindUserAsync(int id);
    }
}
