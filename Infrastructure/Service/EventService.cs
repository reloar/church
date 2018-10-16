using Domain;

namespace Infrastructure
{
    public class EventService : IService<Event>
    {
        private readonly IRepository<Event> _eventrepo;
        public EventService(IRepository<Event> eventrepo)
        {
            _eventrepo = eventrepo;
        }
        public void AddItem(Event entity)
        {
            _eventrepo.Add(entity);
        }

        public void Clear()
        {

        }

        public void RemoveItem(Event entity)
        {
            _eventrepo.Remove(entity);
        }
    }
}

