using System;
using B_FILE;
using B_CONSOLE;
using static Resources.MyResources;

namespace A
{
    public static class MainLogic
    {
        public static event MyAlinHandler CrossProjectEvent;

        public static void AttachFileProject()
        {
            CrossProjectEvent += FileManager.Print;
        }

        public static void AttachConsoleProject()
        {
            CrossProjectEvent += ConsoleManager.Print;
        }

        public static void AttachWebProject(MyAlinHandler method)
        {
            CrossProjectEvent += method;
        }

        public static void RaiseMyAlinEvent(string text)
        {
            CrossProjectEvent?.Invoke(text.ToUpper());
            CrossProjectEvent = null;
        }
    }
}
