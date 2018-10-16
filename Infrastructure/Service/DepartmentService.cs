using Domain;

namespace Infrastructure
{
    class DepartmentService : IService<Department>
    {
        private readonly IRepository<Department> _deptrepo;
        public DepartmentService(IRepository<Department> deptrepo)
        {
            _deptrepo = deptrepo;
        }
        public void AddItem(Department entity)
        {
            _deptrepo.Add(entity);
        }

        public void Clear()
        {

        }

        public void RemoveItem(Department entity)
        {
            _deptrepo.Remove(entity);
        }
    }
}
