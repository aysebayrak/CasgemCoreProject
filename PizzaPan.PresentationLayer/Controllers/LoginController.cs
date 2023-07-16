using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PizzaPan.EntityLayer.Concrete;

namespace PizzaPan.PresentationLayer.Controllers
{

   
   
    public class LoginController : Controller
    {

        private readonly SignInManager<AppUser> _signInManager;

        public LoginController(SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
        }


        public IActionResult Index()
        {
            return View();
        }

     
    }
}
