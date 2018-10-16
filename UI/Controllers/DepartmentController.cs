using Domain;
using System.Web.Mvc;

namespace UI
{
    public class DepartmentController : Controller
    {
        private IUnitOfWork _uow;
        public DepartmentController(IUnitOfWork uow)
        {
            _uow = uow;
        }

        // GET: Department
       [HttpGet]
        public ActionResult DepartmentCorner()
        {
            var currentdepartment = _uow.Departments.GetAll(); 

            var dvm = new DeptListViewModel
            {
                
                AllDepartment= currentdepartment

            };
            return View(dvm);          
        }
        
    }
}