using System.Web;
using System.Web.Optimization;

namespace Learning_Development
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new Bundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            
            bundles.Add(new Bundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.bundle.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/site.css"));

            //Agregar js scripts

            bundles.Add(new Bundle("~/bundles/assets").Include("~/Scripts/scripts.js",
                "~/Scripts/fontawesome/all.min.js"));


        }
    }
}
