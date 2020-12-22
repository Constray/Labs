using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Database.EFCore.Dao;
using Database.EFCore.Entities;

namespace WebApp.Services
{
    public class ProductService : IProductService
    {
        private IProductDataAccess ProductDataAccess { get; }
        
        public ProductService(IProductDataAccess productDataAccess)
        {
            ProductDataAccess = productDataAccess;
        }

        public async Task<IEnumerable<ProductEntity>> GetProducts(CancellationToken ct = default)
        {
            return await ProductDataAccess.GetAllAsync(ct);
        }
    }
}