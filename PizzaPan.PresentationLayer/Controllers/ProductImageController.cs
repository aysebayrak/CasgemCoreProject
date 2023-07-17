using Microsoft.AspNetCore.Mvc;
using PizzaPan.PresentationLayer.Models;

namespace PizzaPan.PresentationLayer.Controllers
{
    public class ProductImageController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(ImageFileViewModel model)
        {
            return View();
        }
    }
}
