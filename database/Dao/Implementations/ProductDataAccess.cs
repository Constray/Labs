using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Database.EFCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace Database.EFCore.Dao.Implementations
{
    public class ProductDataAccess : IProductDataAccess
    {
        private ExampleContext ExampleContext { get; }
        
        public ProductDataAccess(ExampleContext exampleContext)
        {
            ExampleContext = exampleContext;
        }
        
        public async Task<IEnumerable<ProductEntity>> GetAllAsync(CancellationToken ct = default)
        {
            return await ExampleContext.Products.
                    OrderBy(product => product.CreationDate)
                    .ToListAsync(ct);
        }
    }
}