﻿using System.Web.Optimization;

namespace NonFactors.Mvc.Grid.Web
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            RegisterScripts(bundles);
            RegisterStyles(bundles);
        }
        private static void RegisterScripts(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/Scripts/Page/Bundle")
                .Include("~/Scripts/MvcGrid/*.js")
                .Include("~/Scripts/Shared/*.js"));
        }
        private static void RegisterStyles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/Page/Bundle")
                .Include("~/Content/Bootstrap/*.css")
                .Include("~/Content/FontAwesome/*.css")
                .Include("~/Content/MvcGrid/*.css")
                .Include("~/Content/Shared/*.css"));
        }
    }
}
