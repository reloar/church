using Domain;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UI
{
    public class WorkerListViewModel
    {
        public IPagedList<IWorker> Workers { get; set; }
    }
}