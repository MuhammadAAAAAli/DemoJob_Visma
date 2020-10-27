using Resources;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using static Resources.MyResources;

namespace B_CONSOLE
{
    public static class ConsoleManager
    {
        public static void Print(string text)
        {
            var proc1 = new ProcessStartInfo
            {
                UseShellExecute = true,
                WorkingDirectory = @"C:\Windows\System32",
                FileName = @"C:\Windows\System32\cmd.exe",
                Arguments = "/k " + @"echo " + text
            };
            Process.Start(proc1);
        }
    }
}
