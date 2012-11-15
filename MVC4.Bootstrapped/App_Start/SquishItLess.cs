[assembly: WebActivator.PreApplicationStartMethod(typeof(MVC4.Bootstrapped.App_Start.SquishItLess), "Start")]

namespace MVC4.Bootstrapped.App_Start
{
    using SquishIt.Framework;
    using SquishIt.Less;

    public class SquishItLess
    {
        public static void Start()
        {
            Bundle.RegisterStylePreprocessor(new LessPreprocessor());
        }
    }
}