using System;
using System.Diagnostics;
using System.Threading;

namespace ChromeDriverKill
{
    internal static class Program
    {
        public static void Main()
        {
            var kp = Process.GetProcessesByName("chromedriver");
            if (kp.Length == 0) return;
            
            foreach (var p in kp)
                p.Kill();

            Console.WriteLine("All killed chrome process.(await crk)");
            Console.ReadKey();
        }
    }
}