using System.Globalization;
using System.Threading;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace GBlog
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            CultureInfo culture = (CultureInfo)CultureInfo.CurrentCulture.Clone();
            culture.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy";
            culture.DateTimeFormat.LongTimePattern = "HH:mm:ss dd/MM/yyyy";
            Thread.CurrentThread.CurrentCulture = culture;

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            BootstrapContainer();
        }

        /// <summary>
        /// Bootstraps the container.
        /// </summary>
        private void BootstrapContainer()
        {
            ControllerBuilder.Current.SetControllerFactory(new StructureMapControllerFactory());
        }
    }
}
