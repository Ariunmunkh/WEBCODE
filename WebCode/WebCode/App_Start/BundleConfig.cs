using System.Web;
using System.Web.Optimization;

namespace WebCode
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css" +
                      "~/Content/css/responsive.css" +
                      "~/Content/css/style.css"));


            //START Vendor
            bundles.Add(new ScriptBundle("~/bundles/vendor").Include(
                   "~/Content/vendor/bootstrap/bootstrap.js" +
                   "~/Content/vendor/bootstrap/bootstrap.min.js" +
                   "~/Content/vendor/bootstrap-select/js/bootstrap-select.js" +                  
                   "~/Content/vendor/bootstrap-select/Gruntfile.js" +
                   "~/Content/vendor/bootstrap-select/js/bootstrap-select.js" +
                   "~/Content/vendor/contact-form/jquery.form.js" +
                   "~/Content/vendor/contact-form/validate.js" +
                   "~/Content/vendor/fancy-box/jquery.fancybox-media.js" +
                   "~/Content/vendor/fancy-box/jquery.fancybox.pack.js" +
                   "~/Content/vendor/owl-carousel/owl-carousel.min.js" +
                   "~/Content/vendor/owl-carousel/owl-carousel.min.js" +
                   "~/Content/vendor/revolution/jquery.themepunch.revolution.min.js" +
                   "~/Content/vendor/revolution/jquery.themepunch.tools.min.js" +
                   "~/Content/vendor/revolution/jquery.extension.actions.min.js" +
                   "~/Content/vendor/revolution/jquery.extension.kenburn.min.js" +
                   "~/Content/vendor/revolution/jquery.extension.layeranimation.min.js" +
                   "~/Content/vendor/revolution/jquery.extension.navigation.min.js" +
                   "~/Content/vendor/revolution/jquery.extension.slideanims.min.js" +
                   "~/Content/vendor/skills-master/jquery.skills.js" +
                   "~/Content/vendor/gmap.js" +
                   "~/Content/vendor/html5shiv.js" +
                   "~/Content/vendor/jquery-2.1.4.js" +
                   "~/Content/vendor/jquery.appear.js" +
                   "~/Content/vendor/jquery.countTo.js" +
                   "~/Content/vendor/jquery.mixitup.min.js" +
                   "~/Content/vendor/respond.js" +
                   "~/Content/js/map-script.js"));
            //END Vendor
            //START CSS
            bundles.Add(new StyleBundle("~/Content/charitycss").Include(
                    "~/Content/vendor/bootstrap/bootstrap-theme.css",
                    "~/Content/vendor/bootstrap/bootstrap-theme.css.map" +
                    "~/Content/vendor/bootstrap/bootstrap-theme.min.css" +
                    "~/Content/vendor/bootstrap/bootstrap.css" +
                    "~/Content/vendor/bootstrap/bootstrap.min.css" +
                    "~/Content/vendor/bootstrap-select/dist/css/bootstrap-select.css" +
                    "~/Content/vendor/bootstrap-select/dist/css/bootstrap-select.css.map" +
                    "~/Content/vendor/bootstrap-select/dist/css/bootstrap-select.min.css" +
                    "~/Content/vendor/bootstrap/bootstrap.css.map" +
                    "~/Content/vendor/owl-carousel/animate.css" +
                    "~/Content/vendor/owl-carousel/owl.carousel.css" +
                    "~/Content/vendor/owl-carousel/owl.theme.css" +
                    "~/Content/vendor/revolution/layers.css" +
                    "~/Content/vendor/revolution/navigation.css" +
                    "~/Content/vendor/revolution/settings.css" +
                    "~/Content/vendor/skills-master/source/animate.css" +
                    "~/Content/vendor/skills-master/source/habilidades.css" +
                    "~/Content/vendor/hover.css" +
                    "~/Content/js/theme.css" +
                    "~/Content/vendor/bootstrap-select/less/bootstrap-select.less" +
                    "~/Content/vendor/bootstrap-select/less/variables.less" +
                    "~/Content/vendor/bootstrap-select/sass/bootstrap-select.scss" +
                    "~/Content/vendor/bootstrap-select/sass/variables.less"));
            //END CSS
        }
    }
}
