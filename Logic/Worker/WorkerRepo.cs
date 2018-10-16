using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class WorkerRepo : Repository<Worker>, IWorkerRepo
    {
        public WorkerRepo(PraiseDbContext context) : base(context)
        {
            //_DbContext = context;
        }

        public IEnumerable<Worker> GetCurrentWorker
        {
            get { return GetAll(); }
            //get { return this.Find(c => c.WorkerName==n).Take(6).OrderBy(c => c.Department); }

        }
    }
}

