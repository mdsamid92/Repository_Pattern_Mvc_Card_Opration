using System.Web;
using System.Web.Mvc;

namespace Repository_Pattern_Mvc_Card_Opration
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
