using Microsoft.AspNetCore.Mvc;
using PizzaPan.BussinesLayer.Abstract;
using PizzaPan.BussinesLayer.ValidationRules.OurTeamValidator;
using PizzaPan.EntityLayer.Concrete;
using System.ComponentModel.DataAnnotations;

namespace PizzaPan.PresentationLayer.Controllers
{
    public class OurTeamController : Controller
    {
        private readonly IOurTeamService _ourTeamService;

        public OurTeamController(IOurTeamService ourTeamService)
        {
            _ourTeamService = ourTeamService;
        }

        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
          public IActionResult  AddOurTeam()
        {
            return View();
        }

        //[HttpPost]
        //public IActionResult AddOurTeam(OurTeam ourTeam)
        //{
        //    CreateOurTeamValidator createOurTeamValidator = new CreateOurTeamValidator();
        //    ValidationResult result = createOurTeamValidator.Validate(ourTeam);

            

        //}


    }
}
