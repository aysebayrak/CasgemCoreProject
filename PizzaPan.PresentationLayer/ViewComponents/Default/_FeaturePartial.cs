using Microsoft.AspNetCore.Mvc;

namespace PizzaPan.PresentationLayer.ViewComponents.Default
{
    public class _FeaturePartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            ViewBag.title1 = "Her Gün Pizza Yiğin";
            ViewBag.title2 = "Sevdiğin Pizzaları Paylaşın";
            return View();
        }
    }
}
