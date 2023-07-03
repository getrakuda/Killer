using System.Diagnostics;

namespace ChromeAndDriverKill
{
    internal static class Program
    {
        public static void Main()
        {
            var chrome = Process.GetProcessesByName("chrome");
            var chromeDriver = Process.GetProcessesByName("chromedriver");

            if (chrome.Length != 0)
                foreach (var chromeP in chrome)
                    chromeP.Kill();

            if (chromeDriver.Length == 0) return;
            foreach (var chromeDriverP in chromeDriver)
                chromeDriverP.Kill();

        }
    }
}