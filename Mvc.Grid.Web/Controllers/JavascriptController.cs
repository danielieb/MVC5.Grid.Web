using NonFactors.Mvc.Grid.Web.Context;
using System;
using System.Threading;
using System.Web.Mvc;

namespace NonFactors.Mvc.Grid.Web.Controllers
{
    public class JavascriptController : Controller
    {
        [HttpGet]
        public ViewResult Api()
        {
            return View(PeopleRepository.GetPeople());
        }

        [HttpGet]
        public ViewResult RowClicked()
        {
            return View(PeopleRepository.GetPeople());
        }

        [HttpGet]
        public ViewResult Reload()
        {
            return View(PeopleRepository.GetPeople());
        }

        [AcceptVerbs(HttpVerbs.Get | HttpVerbs.Post)]
        public PartialViewResult ReloadGrid(String name)
        {
            return PartialView("_ReloadGrid", PeopleRepository.GetPeople(name));
        }

        [HttpGet]
        public ViewResult RequestType()
        {
            return View(PeopleRepository.GetPeople());
        }

        [HttpGet]
        public ViewResult ReloadEvents()
        {
            return View(PeopleRepository.GetPeople());
        }

        [HttpGet]
        public PartialViewResult ReloadEventsGrid()
        {
            Thread.Sleep(2000);

            return PartialView("_ReloadEventsGrid", PeopleRepository.GetPeople());
        }
    }
}
