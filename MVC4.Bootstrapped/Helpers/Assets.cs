using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SquishIt.Framework;

namespace MVC4.Bootstrapped.Helpers
{
    public static class Assets
    {

        public static MvcHtmlString RenderScripts(this HtmlHelper htmlHelper)
        {
            var bundle = Bundle.JavaScript()
#if DEBUG
                .Add("~/scripts/jquery-1.8.2.js")
                .Add("~/scripts/jquery.unobtrusive-ajax.js")
                .Add("~/scripts/jquery.validate.js")
                .Add("~/scripts/jquery.validate.unobtrusive.js")
                .ForceDebug()
#else
                .AddMinified("~/scripts/jquery-1.8.2.min.js")
                .AddMinified("~/scripts/jquery.unobtrusive-ajax.min.js")
                .AddMinified("~/scripts/jquery.validate.min.js")
                .AddMinified("~/scripts/jquery.validate.unobtrusive.min.js")
                .ForceRelease()
#endif
                .Add("~/scripts/modernizr-2.6.2.js")
                .Render("combined.js");

            return new MvcHtmlString(bundle);    
        }

        public static MvcHtmlString RenderStyles(this HtmlHelper htmlHelper)
        {
            var bundle = Bundle.Css()
                .Add("~/content/styles/site.css")
                .ProcessImports()
#if DEBUG
                .AppendHashForAssets()
                .ForceDebug()
#else
                .ForceRelease()
#endif
            .Render("combined.css");

            return new MvcHtmlString(bundle);
        }

        public static MvcHtmlString RenderMobileScripts(this HtmlHelper htmlHelper)
        {
            var bundle = Bundle.JavaScript()
#if DEBUG
                .Add("~/scripts/jquery.mobile-1.2.0.js")
                .ForceDebug()
#else
                .AddMinified("~/scripts/jquery.mobile-1.2.0.min.js")
                .ForceRelease()
#endif
                .Render("mobile.js");

            return new MvcHtmlString(bundle);
        }

        public static MvcHtmlString RenderMobileStyles(this HtmlHelper htmlHelper)
        {
            var bundle = Bundle.Css()
#if DEBUG
                .Add("~/content/themes/jquery.mobile.structure-1.2.0.css")
                .Add("~/content/themes/jquery.mobile-1.2.0.css")
                .AppendHashForAssets()
                .ForceDebug()
#else
                .AddMinified("~/content/themes/jquery.mobile.structure-1.2.0.min.css")
                .AddMinified("~/content/themes/jquery.mobile-1.2.0.min.css")
                .ForceRelease()
#endif
.ProcessImports()
                .Render("combined.css");

            return new MvcHtmlString(bundle);
        }
    }
}