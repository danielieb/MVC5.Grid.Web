using NonFactors.Mvc.Grid.Web.Context;
using NonFactors.Mvc.Grid.Web.Models;
using System.Linq;
using System.Web.Mvc;

namespace NonFactors.Mvc.Grid.Web.Controllers
{
    public class GridController : Controller
    {
        [HttpGet]
        public ActionResult Build()
        {
            return View(PeopleRepository.GetPeople());
        }

        [HttpGet]
        public ActionResult ProcessWith()
        {
            return View(PeopleRepository.GetPeople());
        }

        [HttpGet]
        public ActionResult DataSource()
        {
            return View(PeopleRepository.GetPeople());
        }

        [HttpGet]
        public ActionResult GridPartial()
        {
            return PartialView("_DataSourceGrid", PeopleRepository.GetPeople());
        }

        [HttpGet]
        public ActionResult Filterable()
        {
            return View(PeopleRepository.GetPeople());
        }

        [HttpGet]
        public ActionResult Sortable()
        {
            return View(PeopleRepository.GetPeople());
        }

        [HttpGet]
        public ActionResult RowCss()
        {
            return View(PeopleRepository.GetPeople());
        }

        [HttpGet]
        public ActionResult Css()
        {
            return View(PeopleRepository.GetPeople());
        }

        [HttpGet]
        public ActionResult Empty()
        {
            return View(Enumerable.Empty<PersonModel>());
        }

        [HttpGet]
        public ActionResult Named()
        {
            return View(PeopleRepository.GetPeople());
        }

        [HttpGet]
        public ActionResult Pageable()
        {
            return View(PeopleRepository.GetPeople());
        }

        [HttpGet]
        public ActionResult Localization()
        {
            return View(PeopleRepository.GetPeople());
        }
    }
}