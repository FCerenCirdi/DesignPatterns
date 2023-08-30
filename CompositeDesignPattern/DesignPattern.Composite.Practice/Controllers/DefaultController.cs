using DesignPattern.Composite.Practice.CompositePattern;
using DesignPattern.Composite.Practice.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DesignPattern.Composite.Practice.Controllers
{
    public class DefaultController : Controller
    {
        private readonly Context _context;

        public DefaultController(Context context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var departments = _context.Departments.Include(x => x.Employees).ToList();
            var values = Rekursive(departments, new Department { DepartmentName = "FirstDeparment", DepartmentID = 0 }, new EmployeeComposite(0, "FirstComposite"));
            ViewBag.v=values;
            return View();
        }
        public EmployeeComposite Rekursive(List<Department> departments, Department firstDepartment, EmployeeComposite firstComposite,EmployeeComposite leaf= null)
        {
            departments.Where(x => x.SubDepartmentID == firstDepartment.DepartmentID).ToList().ForEach(y =>
            {
                var employeeComposite = new EmployeeComposite(y.DepartmentID, y.DepartmentName);
                y.Employees.ToList().ForEach(z =>
                {
                    employeeComposite.Add(new EmployeeComponent(z.EmployeeID, z.EmployeeName));
                });
                if (leaf != null)
                {
                    leaf.Add(employeeComposite);
                }
                else
                {
                    firstComposite.Add(employeeComposite);
                }
                Rekursive(departments, y, firstComposite, employeeComposite);

            });
            return firstComposite;
        }
    }
}
