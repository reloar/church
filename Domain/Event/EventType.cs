using System.Collections.Generic;

namespace Domain
{
    public class EventType : Entity, IAggregateRoot, IEventType
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Event> Events { get; set; }

    }
}