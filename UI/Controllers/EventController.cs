using Domain;
using System.Web.Mvc;

namespace UI
{
    public class EventController : Controller
    {
        IUnitOfWork _uow;
        public EventController(IUnitOfWork uow)
        {
            _uow = uow;
        }
        // GET: Event
        public ActionResult EventDetails(int id)
        {
            var _event = _uow.Events.Get(id);
            Event singleevent = _event;

            return View(singleevent);
        }

        public ActionResult UpcomingEvents()
        {
            var upcomingevent = _uow.Events.GetAll();
            var hvm = new EventViewModel
            {
                Events = upcomingevent

            };
            return View(hvm);
        }
        public ActionResult EventCalendar()
        {
            var eventcalendar = _uow.Events.GetAll();
            var evm = new EventViewModel
            {
                Events = eventcalendar
            };
            return View(evm);
        }
        //public ActionResult EventbyCategory(string name)
        //{

        //    var sermonscategory = _uow.Events.Find(sc => sc.e.SermonName == name);

        //    var svm = new SermonViewModel
        //    {
        //        Sermons = sermonscategory,
        //        SermonCategory = name

        //    };
        //    return View("Index", svm);
        //}

    }
}