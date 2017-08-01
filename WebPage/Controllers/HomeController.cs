using System.IO;
using System.Net;
using System.Web.Mvc;
using DataConatiner;
using HangoutsNetwork.Models;
using WebPage.Models;

namespace WebPage.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            WebRequest request = WebRequest.Create(ApiInfo.ServerAddress+ApiInfo.EventListRequest);
            WebResponse response = request.GetResponse();
            string text = "";
            using (StreamReader reader = new StreamReader(response.GetResponseStream()))
            {
                text = reader.ReadToEnd();
            }

            EventInfo[] events = JsonUtils.GetEvetnsFromJson(text);
            ViewBag.Events = events;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}