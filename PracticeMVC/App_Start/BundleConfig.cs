using System.Web;
using System.Web.Optimization;

namespace PracticeMVC
{
    public class BundleConfig
    {
        // 如需「搭配」的詳細資訊，請瀏覽 http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            //bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
            //            "~/dist/Scripts/jquery-{version}.js"));

            //bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
            //            "~/dist/Scripts/jquery.validate*"));

            //// 使用開發版本的 Modernizr 進行開發並學習。然後，當您
            //// 準備好實際執行時，請使用 http://modernizr.com 上的建置工具，只選擇您需要的測試。
            //bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
            //            "~/dist/Scripts/modernizr-*"));

            //bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
            //          "~/dist/Scripts/bootstrap.js",
            //          "~/dist/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/Scripts").Include(
                "~/dist/Scripts/*.js",
                "~/dist/Scripts/jquery-{version}.js",
                      "~/dist/Scripts/jquery.validate*",
                      "~/dist/Scripts/modernizr-*",
                      "~/dist/Scripts/bootstrap.js",
                      "~/dist/Scripts/respond.js",
                      "~/dist/Scripts/angular.min.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/dist/css/bootstrap.css",
                      "~/dist/css/*.css"));
        }
    }
}
