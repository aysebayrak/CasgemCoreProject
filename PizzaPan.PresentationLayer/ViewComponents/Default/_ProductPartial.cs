using Microsoft.AspNetCore.Mvc;
using PizzaPan.BussinesLayer.Abstract;

namespace PizzaPan.PresentationLayer.ViewComponents.Default
{
    public class _ProductPartial : ViewComponent
    {
        private readonly IProductService _productService;
        public _ProductPartial(IProductService  productService) 
        {
            _productService = productService;   
        }



        public IViewComponentResult Invoke()
        {
            var values = _productService.TGetList();
            return View(values);
        }
    }
}
