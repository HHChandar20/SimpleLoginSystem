using SimpleLoginSystem.PL.Views;

namespace SimpleLoginSystem.PL.Run
{
    internal static class Source
    {
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new LoginMenu());
        }
    }
}