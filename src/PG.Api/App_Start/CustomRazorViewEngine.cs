using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PG.Api
{
    public class CustomRazorViewEngine : RazorViewEngine
    {
        public CustomRazorViewEngine()
        {
            ViewLocationFormats = new[]
            {
                "~/Domains/{1}/{0}.cshtml"
            };

            MasterLocationFormats = new[]
            {
                "~/Domains/{1}/{0}.cshtml",
                "~/Domains/Base/Views/{0}.cshtml"
            };

            PartialViewLocationFormats = new[]
            {
                "~/Domains/{1}/{0}.cshtml",
                "~/Domains/Base/Views/{0}.cshtml"
            };
        }
    }
}