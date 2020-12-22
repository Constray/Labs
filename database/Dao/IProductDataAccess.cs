using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Database.EFCore.Entities;

namespace Database.EFCore.Dao
{
    public interface IProductDataAccess
    {
        public Task<IEnumerable<ProductEntity>> GetAllAsync(CancellationToken ct = default);
    }
}