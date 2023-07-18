using Microsoft.AspNetCore.Mvc;
using PizzaPan.BussinesLayer.Abstract;

namespace PizzaPan.PresentationLayer.ViewComponents.Default
{
    public class _TestimonialPartial  : ViewComponent
    {
        private readonly ITestimanialService _testimanialService;

        public _TestimonialPartial(ITestimanialService testimanialService)
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
