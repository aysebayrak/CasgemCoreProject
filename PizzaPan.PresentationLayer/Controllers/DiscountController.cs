using Microsoft.AspNetCore.Mvc;
using PizzaPan.BussinesLayer.Abstract;
using PizzaPan.EntityLayer.Concrete;
using System;

namespace PizzaPan.PresentationLayer.Controllers
{
    public class DiscountController : Controller
    {

        private readonly IDiscountService _discountService;

        public DiscountController(IDiscountService discountService)
        {
            _discountService = discountService;
        }


        [HttpGet]
        public IActionResult CreateCode()
        {
            string[] symbols = { "A", "B", "C", "F", "E", "D", "Y" };
            int c1, c2, c3, c4, c5;
            Random random = new Random();
            c1 = random.Next(0, symbols.Length);
            c2 = random.Next(0, symbols.Length);
            c3 = random.Next(0, symbols.Length);
            c4 = random.Next(0, symbols.Length);
            c5 = random.Next(10, 100);
            ViewBag.v = symbols[c1] + symbols[c2] + symbols[c3] + symbols[c4] + c5;
            return View();

        }



        [HttpPost]
        public IActionResult CreateCode(Discount discount)
        {

            discount.CreationDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            discount.LastDate = Convert.ToDateTime(DateTime.Now.AddDays(3));
            _discountService.TInsert(discount);
            return RedirectToAction("DiscountCodeList");


        }


        public IActionResult DiscountCodeList()
        {
            var values = _discountService.TGetList();
            return View(values);


        }



    }

}
