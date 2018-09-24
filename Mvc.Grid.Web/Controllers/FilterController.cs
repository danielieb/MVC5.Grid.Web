using NonFactors.Mvc.Grid.Web.Context;
using System.Web.Mvc;

namespace NonFactors.Mvc.Grid.Web.Controllers
{
    public class FilterController : Controller
    {
        [HttpGet]
        public ViewResult Register()
        {
            return View(PeopleRepository.GetPeople());
        }

        [HttpGet]
        public ViewResult Unregister()
        {
            return View(PeopleRepository.GetPeople());
        }
    }
}
