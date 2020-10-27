using System;

namespace Resources
{
    public static class MyResources
    {
        public static string desktopFilePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\alin_file.txt";
        public delegate void MyAlinHandler(string text);

    }
}
