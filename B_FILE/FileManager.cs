using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_FILE
{
    public class FileManager
    {
        public static void Print(string text)
        {
            File.WriteAllText(Resources.MyResources.desktopFilePath,text);
            System.Diagnostics.Process.Start(Resources.MyResources.desktopFilePath);
        }
    }
}
