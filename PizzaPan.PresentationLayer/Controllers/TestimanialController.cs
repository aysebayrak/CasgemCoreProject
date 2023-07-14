using Microsoft.AspNetCore.Mvc;

namespace PizzaPan.PresentationLayer.Controllers
{
    public class TestimanialController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
