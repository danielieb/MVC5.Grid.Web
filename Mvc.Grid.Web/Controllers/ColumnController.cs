using NonFactors.Mvc.Grid.Web.Context;
using System.Web.Mvc;

namespace NonFactors.Mvc.Grid.Web.Controllers
{
    public class ColumnController : Controller
    {
        [HttpGet]
        public ActionResult RenderedAs()
        {
            return View(PeopleRepository.GetPeople());
        }

        [HttpGet]
        public ActionResult Filterable()
        {
            return View(PeopleRepository.GetPeople());
        }

        [HttpGet]
        public ActionResult FilteredAs()
        {
            return View(PeopleRepository.GetPeople());
        }

        [HttpGet]
        public ActionResult FirstSortIn()
        {
            return View(PeopleRepository.GetPeople());
        }

        [HttpGet]
        public ActionResult Sortable()
        {
            return View(PeopleRepository.GetPeople());
        }

        [HttpGet]
        public ActionResult Encoded()
        {
            return View(PeopleRepository.GetPeople());
        }

        [HttpGet]
        public ActionResult Formatted()
        {
            return View(PeopleRepository.GetPeople());
        }

        [HttpGet]
        public ActionResult Css()
        {
            return View(PeopleRepository.GetPeople());
        }

        [HttpGet]
        public ActionResult Titled()
        {
            return View(PeopleRepository.GetPeople());
        }

        [HttpGet]
        public ActionResult Named()
        {
            return View(PeopleRepository.GetPeople());
        }
    }
}