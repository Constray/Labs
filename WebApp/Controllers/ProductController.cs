using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApp.Models;
using WebApp.Services;

namespace WebApp.Controllers
{
    public class ProductController : Controller
    {
        private IProductService ProductService { get; }

        public ProductController(IProductService productService)
        {
            ProductService = productService;
        }
        
        public async Task<IActionResult> Index()
        {
            return View(await ProductService.GetProducts());
        }
    }
}