﻿using NonFactors.Mvc.Grid.Web.Filters;
using System;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;

namespace NonFactors.Mvc.Grid.Web
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            (MvcGrid.Filters as GridFilters).BooleanTrueOptionText = () => "True";
            (MvcGrid.Filters as GridFilters).BooleanFalseOptionText = () => "False";
            MvcGrid.Filters.Register(typeof(Int32), "contains", typeof(NumberContainsFilter));
        }
    }
}
