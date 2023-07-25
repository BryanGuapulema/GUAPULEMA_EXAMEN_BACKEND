using System.Web;
using System.Web.Mvc;

namespace GUAPULEMA_EXAMEN
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
