using Microsoft.AspNetCore.Mvc;
using Project.Data.Abstract;

namespace Project.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private IProductRepository _productRepository;
        public HomeController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
