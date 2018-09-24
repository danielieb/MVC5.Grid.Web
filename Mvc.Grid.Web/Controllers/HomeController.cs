﻿using NonFactors.Mvc.Grid.Web.Context;
using System.Web.Mvc;

namespace NonFactors.Mvc.Grid.Web.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ViewResult Index()
        {
            return View(PeopleRepository.GetPeople());
        }

        [HttpGet]
        public ViewResult Installation()
        {
            return View();
        }
    }
}
