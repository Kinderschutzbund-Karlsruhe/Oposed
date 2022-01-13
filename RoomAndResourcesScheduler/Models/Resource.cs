﻿using RoomAndResourcesScheduler.Enum;

namespace RoomAndResourcesScheduler.Models
{
    public class Resource
    {
        public int Id { get; set; }
        public ResourceType Type { get; set; }
        public string Name { get; set; }
        public string? Image { get; set; } = null;
        public string Description { get; set; }
    }
}