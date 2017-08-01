using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using DataConatiner;
using HangoutsNetwork.Models;
using NUnit.Framework;

namespace DataTools.Tests
{
    [TestFixture]
    public class UtilsTest
    {
        [Test]
        public void TestDeserialize()
        {
            WebRequest request = WebRequest.Create("http://localhost:49883/api/Events");
            WebResponse response = request.GetResponse();
            string text = "";
            using (StreamReader reader = new StreamReader(response.GetResponseStream()))
            {
                text = reader.ReadToEnd();
            }
            EventInfo[] events = JsonUtils.GetEvetnsFromJson(text);
            Assert.AreEqual(events[0].Name, "Party Hard");

        }
    }
}
