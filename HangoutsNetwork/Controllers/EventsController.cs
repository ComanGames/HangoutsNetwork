using System;
using System.Web.Http;
using HangoutsNetwork.Models;

namespace HangoutsNetwork.Controllers
{
    public class EventsController : ApiController
    {
        private EventInfo[] Events = new EventInfo[]
        {
            new EventInfo() {Id = new Guid("0"),Name = "Party Hard",Type = EventType.Fun,DateAndTime = DateTime.Now + new TimeSpan(1,2,0,50),Description = "House party "},
            new EventInfo() {Id = new Guid("1"),Name = "Code Hard",Type = EventType.Study,DateAndTime = DateTime.Now + new TimeSpan(2,5,30,5),Description = "Yura will write best of the best code ever"},
            new EventInfo() {Id = new Guid("2"),Name = "StartUp meet up",Type = EventType.Business,DateAndTime = DateTime.Now + new TimeSpan(5,3,20,2),Description = "I will earn money on selling tickets to those who want to know about start ups"},
            new EventInfo() {Id = new Guid("3"),Name = "Take your ass from chair",Type = EventType.Travel,DateAndTime = DateTime.Now + new TimeSpan(10,5,8,40),Description = "Try to take your ass from chair"},

        };
    }
}
