using System.Web;
using System.Web.Mvc;

namespace mvc4_webapi_backbone
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}