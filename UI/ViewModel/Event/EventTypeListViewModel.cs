﻿using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UI
{
    public class EventTypeListViewModel
    {
        
            public IEnumerable<IEventType> EventTypes { get; set; } = Enumerable.Empty<IEventType>();

       
    }
}