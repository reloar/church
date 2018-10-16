using Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Logic
{
    public class EventRepo : Repository<Event>, IEventRepo
    {
        public EventRepo(PraiseDbContext context) : base(context)
        {

        }
        public IEnumerable<Event> Event
        {
            get { return this.GetAll(); }
        }

        public Event GetNextEvent
        {
            get { return this.Find(c => c.EventDate <= DateTime.Now).Take(1).OrderBy(c => c.EventName).FirstOrDefault(); }

        }
    }
}
