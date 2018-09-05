using System.Web;
using System.Web.Mvc;

namespace Sava_Load_Scene_OR_Object
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
