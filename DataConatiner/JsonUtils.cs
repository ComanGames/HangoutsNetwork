using HangoutsNetwork.Models;
using System.Web.Http;


namespace DataConatiner
{
    public static class JsonUtils
    {
        public static EventInfo[] GetEvetnsFromJson(string json)
        {
            EventInfo[] events =JavaScriptSerializer().Deserialize<EventInfo[]>(json);
        }
    }
}
