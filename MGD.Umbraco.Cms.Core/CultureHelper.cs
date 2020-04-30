using System.Globalization;
using System.Threading;

namespace MGD.Umbraco.Cms.Core
{
    public static class CultureHelper
    {
        public static void Set(string culture)
        {
            if (!string.IsNullOrEmpty(culture))
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(culture);
                Thread.CurrentThread.CurrentCulture = new CultureInfo(culture);
            }
        }

        public static string Get()
        {
            return Thread.CurrentThread.CurrentCulture.Name;
        }
    }
}