﻿namespace Oposed.Models
{
    public class EventWithSchedule
    {
        public Event Event { get; set; }
        public TimePeriod Schedule { get; set; }
        public bool IsNow { get; set; } = false;
    }
}
