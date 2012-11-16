using System.Web;
using System.Web.Optimization;

namespace MVC4.Bootstrapped
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(
                new ScriptBundle("~/bundles/scripts/jquery")
                    .Include("~/Scripts/jquery-{version}.js")
                );

            bundles.Add(
                new ScriptBundle("~/bundles/scripts/jquery-mobile")
                    .Include("~/Scripts/jquery.mobile-{version}.js")
                );

            bundles.Add(
                new ScriptBundle("~/bundles/scripts/jquery-val")
                    .Include("~/Scripts/jquery.unobtrusive*",
                             "~/Scripts/jquery.validate*")
                );

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(
                new ScriptBundle("~/bundles/scripts/modernizr")
                    .Include("~/Scripts/modernizr-*")
                );

            bundles.Add(
                new StyleBundle("~/bundles/styles/site"
                    ).Include("~/Content/Styles/site.css")
                );

            bundles.Add(
                new StyleBundle("~/bundles/styles/jquery-mobile")
                    .Include("~/Content/Themes/jquery.mobile.structure-{version}.css",
                             "~/Content/Themes/jquery.mobile-{version}.css",
                             "~/Content/Themes/jquery.mobile.theme-{version}.css")
                );
        }
    }
}