using System.Web;
using System.Web.Mvc;

namespace PS1._Practica_Semanal
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
