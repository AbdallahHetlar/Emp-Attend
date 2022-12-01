using System.Web;
using System.Web.Mvc;

namespace Attendance_ManagementV1._0
{
    public static class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
