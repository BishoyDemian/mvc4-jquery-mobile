using System.Web;
using System.Web.Mvc;

namespace MVC4.Bootstrapped
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}