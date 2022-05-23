using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace DigitalCity.ASPNET.Validation.Helper
{
    public static class CustomHTMLHelper
    {
        public static HtmlString DisplayYesNo(this IHtmlHelper htmlHelper, bool value)
        {
            string text = value ? "oui" : "non";
            return new HtmlString(text);
        }
    }
}
