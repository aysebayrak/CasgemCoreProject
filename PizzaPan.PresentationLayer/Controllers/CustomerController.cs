using Microsoft.AspNetCore.Mvc;
using PizzaPan.BussinesLayer.Abstract;

namespace PizzaPan.PresentationLayer.Controllers
{
    public class CustomerController : Controller
    {

        private readonly ICustomerService _customerService;
        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService; 

        }
        public IActionResult Index()
        {
            var values = _customerService.TGetList();
            return View(values);
        }
    }
}
