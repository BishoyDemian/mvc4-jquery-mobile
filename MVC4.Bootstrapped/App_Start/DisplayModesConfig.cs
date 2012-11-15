using System;
using System.Web.WebPages;

namespace MVC4.Bootstrapped.App_Start
{
    public class DisplayModesConfig
    {
        public static void RegisterMobileDisplayModes(DisplayModeProvider displayModeProvider)
        {
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
        }
    }
}