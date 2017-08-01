using System;

namespace HangoutsNetwork.Models
{
    public class EventInfo
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public EventType Type { get; set; }
        public DateTime DateAndTime { get; set; }
        public Location Place { get; set; }
        public string Description { get; set; }
        
    }
}