using System.Web;
using System.Web.Mvc;

namespace NTHBaiTapLon513
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
