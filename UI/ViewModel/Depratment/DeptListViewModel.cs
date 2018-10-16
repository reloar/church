using Domain;
using PagedList;
using System.Collections.Generic;
using System.Linq;

namespace UI
{
    public class DeptListViewModel
    {
        public IPagedList<IDepartment> Departments { get; set; }
        public IEnumerable<IDepartment> AllDepartment { get; set; } = Enumerable.Empty<IDepartment>();
    }
}