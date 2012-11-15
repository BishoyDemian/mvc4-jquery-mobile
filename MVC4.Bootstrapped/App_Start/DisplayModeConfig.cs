using System;
using System.Linq;
using System.Web.WebPages;

namespace MVC4.Bootstrapped.App_Start
{
    public class DisplayModeConfig
    {
        public static void RegisterMobileDisplayModes(DisplayModeProvider displayModeProvider)
        {
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
                    return context.Request.UserAgent.ToLowerInvariant().Contains("iphone")
                           || context.Request.UserAgent.ToLowerInvariant().Contains("ipod")
                           || context.Request.UserAgent.ToLowerInvariant().Contains("android")
                           || context.Request.UserAgent.ToLowerInvariant().Contains("windows phone os")
                           || context.Request.UserAgent.ToLowerInvariant().Contains("blackberry");
                })
            });

        }
    }
}