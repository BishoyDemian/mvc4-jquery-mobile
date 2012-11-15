using System;
using System.Linq;
using System.Web.WebPages;

namespace MVC4.Bootstrapped.App_Start
{
    public class DisplayModeConfig
    {
        public static void RegisterMobileDisplayModes(DisplayModeProvider displayModeProvider)
        {
            // remove existing mobile rules, as we want to treat iPad as normal desktop client since it is capable.
            displayModeProvider.Modes.Remove(displayModeProvider.Modes.First(d => d.DisplayModeId == "Mobile"));

            displayModeProvider.Modes.Add(new DefaultDisplayMode("Iphone")
            {
                ContextCondition = (context => context.Request.UserAgent.IndexOf
                    ("iphone", StringComparison.OrdinalIgnoreCase) >= 0)
            });

            displayModeProvider.Modes.Add(new DefaultDisplayMode("Android")
            {
                ContextCondition = (context => context.Request.UserAgent.IndexOf
                    (/*An*/"Droid", StringComparison.OrdinalIgnoreCase) >= 0)
            });

            displayModeProvider.Modes.Add(new DefaultDisplayMode("WindowsPhone")
            {
                ContextCondition = (context => context.Request.UserAgent.IndexOf
                    ("Windows Phone OS", StringComparison.OrdinalIgnoreCase) >= 0)
            });

            displayModeProvider.Modes.Insert(0, new DefaultDisplayMode("Mobile")
            {
                ContextCondition = (context =>
                                        {
                                            var userAgent = context.Request.UserAgent.ToLowerInvariant();

                                            return userAgent.Contains("iphone")
                                                   || userAgent.Contains("ipod")
                                                   || userAgent.Contains("android")
                                                   || userAgent.Contains("windows phone os")
                                                   || userAgent.Contains("blackberry");
                                        })
            });

        }
    }
}