using System.Web.Script.Serialization;
using HangoutsNetwork.Models;


namespace DataConatiner
{
    public static class JsonUtils
    {
        public static EventInfo[] GetEvetnsFromJson(string json)
        {
           return new JavaScriptSerializer().Deserialize<EventInfo[]>(json);
        }
    }
}
