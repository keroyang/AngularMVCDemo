using System.Web;
using System.Web.Optimization;

namespace WeChat.Web
{
    public class BundleConfig
    {
        // 有关绑定的详细信息，请访问 http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/site.css"));

            bundles.Add(new ScriptBundle("~/bundles/AngularMVCApp")
                .IncludeDirectory("~/Scripts/Controllers", "*.js")
                .Include("~/Scripts/AngularMVCApp.js"));

            BundleTable.EnableOptimizations = true;
            //BundleTable.EnableOptimizations设置为true，MVC4就会启用压缩，将单次引用的资源文件压缩，减少请求数量和带宽，当然在开发调试时一般不开启
        }
    }
}
