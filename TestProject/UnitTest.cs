using System.IO;
using A;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Resources;

namespace UnitTests
{
    [TestClass]
    public class TestSubscribers
    {
        [TestMethod]
        public void TestFileSuscriberOutput()
        {
            var inputText = "Test_File_Subscriber_Output";
            var expectedOutput = inputText.ToUpper();
            MainLogic.AttachFileProject();
            MainLogic.RaiseMyAlinEvent(inputText);
            Assert.AreEqual(expectedOutput, File.ReadAllText(MyResources.desktopFilePath));
        }

        [TestMethod]
        public void TestConsoleSuscriberOutput()
        {
            MainLogic.AttachConsoleProject();
            MainLogic.RaiseMyAlinEvent("Test_Console_Suscriber_Output");

            // this check is VISUAL
        }
    }
}