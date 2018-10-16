using System;

namespace Domain
{
    public class Event : Entity, IAggregateRoot, IEvent
    {
        public string EventName { get; set; }
        public DateTime EventDate { get; set; }
        public string EventTheme { get; set; }
        public string EventLocation { get; set; }
        public string EventImageThumbnailUrl { get; set; }
        public string EventImageUrl { get; set; }
        public string EventDescription { get; set; }
        public virtual EventType Eventtype { get; set; }
    }
}
