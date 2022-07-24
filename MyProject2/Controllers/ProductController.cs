using Microsoft.AspNetCore.Mvc;
using MyProject2.Services;

namespace MyProject2.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            ProductDAO repository = new ProductDAO();
            return View(repository.GetAllProducts());
        }
    }
}
