using Microsoft.EntityFrameworkCore.Storage;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IUnitOfWork
    {
        Task SaveChangesAsync();

        Task<IDbContextTransaction> BeginTransactionAsync();
    }
}