using Microsoft.AspNetCore.Mvc;
using PizzaPan.BussinesLayer.Abstract;

namespace PizzaPan.PresentationLayer.ViewComponents.Default
{
    public class _TestimonialService  : ViewComponent
    {
        private readonly ITestimanialService _testimanialService;

        public _TestimonialService(ITestimanialService testimanialService)
        {
            _testimanialService = testimanialService;
        }


        public IViewComponentResult Invoke()
        {
            var values = _testimanialService.TGetList();
            return View(values);
        }
    }
}
