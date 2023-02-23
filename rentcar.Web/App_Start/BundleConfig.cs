using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web.Optimization;

namespace rentcar.Web.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
           bundles.Add(new StyleBundle("~/bundles/bootstrap/css").Include(
                      "~/Content/bootstrap.min.css"));

            bundles.Add(new StyleBundle("~/bundles/css").Include(
                      "~/Content/main.css",
                      "~/Content/noscript.css"));
            bundles.Add(new ScriptBundle("~/bundles/js").Include(
                    "~/Scripts/Template.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap/js").Include(
                       "~/Content/bootstrap.min.js"
                       ));

            bundles.Add(new StyleBundle("~/bundles/font-awesome").Include(
                       "~/lib/font-awesome/css/font-awesome.css",
                       "~/lib/font-awesome/css/font-awesome.min.css",
                       "~/lib/font-awesome/css/main.css",
                       "~/lib/font-awesome/css/noscript.css"));

            bundles.Add(new ScriptBundle("~/bundles/toaster").Include(
                        "~/lib/toster/index.js"));

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
            "~/Scripts/jquery-3.3.1.js",
            "~/Scripts/jquery-3.3.1.min.js",
            "~/Scripts/jquery.validate.js",
            "~/Scripts/jquery.validate.min.js",
            "~/lib/jquery.scrolly/jquery.scrolly.js",
            "~/lib/jquery.scrollex/jquery.scrollex.js"));




            //bundles.Add(new ScriptBundle("~/bundles/toaster/css").Include(
            //           "~/Vendors/toaster/toaster.min.css", new CssRewriteUrlTransform()));

            //bundles.Add(new ScriptBundle("~/bundles/datatables/css").Include(
            //           "~/Vendors/datatables/datatables.min.css", new CssRewriteUrlTransform()));

        }

    }

}