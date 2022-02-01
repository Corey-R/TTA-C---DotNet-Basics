using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreMVCTutorial.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
