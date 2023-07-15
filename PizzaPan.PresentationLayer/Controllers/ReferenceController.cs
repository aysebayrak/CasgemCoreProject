using Microsoft.AspNetCore.Mvc;
using PizzaPan.BussinesLayer.Abstract;
using PizzaPan.EntityLayer.Concrete;

namespace PizzaPan.PresentationLayer.Controllers
{
    public class ReferenceController : Controller
    {

        private readonly IReferenceService _referenceService;

        public ReferenceController(IReferenceService referenceService)
        {
            _referenceService = referenceService;
        }
    
        public IActionResult Index()
        {
            var values = _referenceService.TGetList();
            return View(values);
        }



        [HttpGet]
        public IActionResult AddReference()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddReference(Reference reference)
        {
           _referenceService.TInsert(reference);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteReference(int id)
        {
            var value = _referenceService.TGetById(id);
            _referenceService.TDelete(value);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult UpdateReference(int id)
        {
            var value = _referenceService.TGetById(id);
            return View();
        }

        [HttpPost]
        public IActionResult UpdateReference(Reference reference)
        {
            _referenceService.TUpdate(reference);
            return RedirectToAction("Index");

        }
    }
}
