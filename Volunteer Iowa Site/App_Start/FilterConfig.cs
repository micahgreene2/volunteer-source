using System.Web;
using System.Web.Mvc;

namespace Volunteer_Iowa_Site
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}