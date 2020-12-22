using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Database.EFCore.Entities;
using WebApp.Models;

namespace WebApp.Services
{
    public interface IProductService
    {
        Task<IEnumerable<ProductEntity>> GetProducts(CancellationToken ct = default);
    }
}