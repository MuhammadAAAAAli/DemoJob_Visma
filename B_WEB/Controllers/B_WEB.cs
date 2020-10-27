using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace B_WEB.Controllers
{
    public class HomeController : Controller
    {
        public static string stringToBeShownOnWeb;

        public string Index()
        {
            return new StringBuilder("  <form id='formid' action=\"/Home/UploadText\" method=\"GET\" enctype=\"text/plain\"> <input id='textid' type='text' name='text'/> <input id='buttonid' type='submit' value='Upload'/> </form> <script>document.getElementById('buttonid').addEventListener('click', openDialog); function openDialog(){document.getElementById('fileid').click();}document.getElementById('fileid').addEventListener('change', submitForm); function submitForm(){document.getElementById('formid').submit();}</script> ").ToString();
        }

        public static void Print(string text)
        {
            stringToBeShownOnWeb = text;
        }

        [HttpGet]
        public string UploadText(string text)
        {
            A.MainLogic.AttachConsoleProject();
            A.MainLogic.AttachFileProject();
            A.MainLogic.AttachWebProject(Print);

            A.MainLogic.RaiseMyAlinEvent(text);
            while (stringToBeShownOnWeb == null)
            {
                Thread.Sleep(100);
            }

            var temp = stringToBeShownOnWeb;
            stringToBeShownOnWeb = null;
            return temp;
        }
    }
}