using System;
using System.Diagnostics;
using System.Threading;

namespace ChromeKill
{
    internal static class Program
    {
        public static void Main()
        {
            var kp = Process.GetProcessesByName("chrome");
            if (kp.Length == 0) return;
            
            foreach (var p in kp)
                p.Kill();

            Console.WriteLine("All killed chrome process.(await crk)");
            Console.ReadKey();
        }
    }
}