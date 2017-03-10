using System.Web;
using System.Web.Optimization;

namespace Delta1
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/js/jquery.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));
            bundles.Add(new ScriptBundle("~/bundles/js").Include(
                        "~/Scripts/js/detect.js",
                        "~/Scripts/js/fastclick.js",
                        "~/Scripts/js/jquery.blockUI.js",
                        "~/Scripts/js/waves.js",
                        "~/Scripts/js/jquery.slimscroll.js",
                        "~/Scripts/js/jquery.scrollTo.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/app").Include(
                        "~/Scripts/js/jquery.core.js",
                        "~/Scripts/js/jquery.app.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.min.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.min.css",
                      "~/Content/components.css",
                      "~/Content/icons.css",
                      "~/Content/menu.css",
                      "~/Content/pages.css",
                      "~/Content/responsive.css",
                      "~/Content/core.css"));

        }
    }
}
