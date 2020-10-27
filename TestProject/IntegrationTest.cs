using System;
using System.Net;
using System.Net.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject
{
    [TestClass]
    public class IntegrationTest
    {
        [TestMethod]
        public void TestWebSuscriberOutput()
        {
            var inputText = "Test_Web_Subscriber_Output";

            // WILL TEST ALL 3 SUBSCRIBERS
            // MAKE SURE WEB SERVER IS STARTED

            // WEB PORT NUMBER
            var port = 44357;

            using (var client = new HttpClient(new HttpClientHandler
                {AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate}))
            {
                client.BaseAddress = new Uri("https://localhost:" + port);
                var response = client.GetAsync("/Home/UploadText?text=" + inputText).Result;
                response.EnsureSuccessStatusCode();
                Assert.AreEqual(inputText.ToUpper(), response.Content.ReadAsStringAsync().Result);
            }

            // for this I need a WEB server running 
            // out of scope
        }
    }
}