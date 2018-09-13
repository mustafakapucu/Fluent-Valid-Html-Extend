using System.Web;
using System.Web.Mvc;

namespace Fluent_Valid_Html_Extend
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
