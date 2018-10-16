using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class DepartmentRepo : Repository<Department>, IDepartmentRepo
    {
        public DepartmentRepo(PraiseDbContext context) : base(context)
        {

        }
        public IEnumerable<Department> Department
        {
            get { return this.GetAll(); }
        }

    }
}
