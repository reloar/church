using Domain;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UI
{
    public class EventListViewModel
    {
        public IPagedList<IEvent> Events { get; set; }
      
    }
}