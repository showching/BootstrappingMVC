using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BootstrappingMVC.Helpers
{
    public class Bootstrap
    {
        public const string BundleBase = "~/Content/css/";

        public class Theme
        {
            public const string Superhero = "Superhero";
            public const string Readable = "Readable";
            public const string Darkly = "Darkly";
        }

        public static HashSet<string> Themes = new HashSet<string>
        {
            Theme.Superhero,
            Theme.Readable,
            Theme.Darkly
        };

        public static string Bundle(string themename)
        {
            return BundleBase + themename;
        }
    }
}