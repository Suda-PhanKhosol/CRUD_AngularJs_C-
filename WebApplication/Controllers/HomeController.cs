using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using WebApplication.Models;

namespace WebApplication.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
        private readonly AngularContext _context;

	public HomeController(ILogger<HomeController> logger , AngularContext context)
		{
			_logger = logger;
			_context = context;
		}

		public IActionResult Index()
		{
			var emp = new EmployeeModel();
			emp.En = "025614";
			emp.Name = "Wansao";
			emp.Department = "IT";
			emp.Age = 37;
			var empData = _context.Employees.Include(l => l.Department).FirstOrDefault(w => w.En == "026037");
			ViewBag.empl = empData;
			return View(emp);
		}

		[HttpGet]
		public JsonResult GetEmployee()
		{

			var empData = _context.Employees.Include(l => l.Department).ToList();
			return Json(empData);
		}
		[HttpGet]
		public JsonResult GetDepartment()
		{

			var department = _context.Departments.ToList();
			return Json(department);
		}

		[HttpPost]
		public JsonResult InsertEmployee([FromBody] Employee emp)
		{
            var empdata = new Employee()
            {
                En = emp.En,
                Name = emp.Name,
                Age = emp.Age,
                Salary= emp.Salary,
                DepartmentId = emp.DepartmentId,
				Alive = "Y"
            };

            _context.Add(empdata);
            _context.SaveChanges();

            return Json("ss");
		}
		[HttpPost]
		public JsonResult UpdateEmployee([FromBody] List<Employee> data)
		{
			//row = alive เก่าจากหน้าบ้าน
			foreach (var row in data) {
				//oldData = alive เก่าจากหลังบ้าน
				var oldData = _context.Employees.FirstOrDefault(w => w.En == row.En);
				//เทียบว่า ค่าเก่า ต่างจาก ค่าใหม่ไหม ถ้าต่างให้เปลี่ยน
				if (oldData.Alive != row.Alive || oldData.En != row.En || oldData.Name != row.Name || oldData.Age != row.Age || oldData.Salary != row.Salary || oldData.DepartmentId != row.DepartmentId) {
					//ยัดค่าใหม่ใส่ค่าเก่า
					oldData.Alive = row.Alive;
					oldData.En = row.En;
					oldData.Name = row.Name;
					oldData.Age = row.Age;
					oldData.Salary = row.Salary;
					oldData.DepartmentId = row.DepartmentId;
					_context.Update(oldData);
					_context.SaveChanges();
				}
			}
			return Json("ss");
		}
		[HttpPost]
		public JsonResult DeleteEmployee([FromBody] Employee emp)
		{
			_context.Remove(emp);
			_context.SaveChanges();
			return Json("ss");
		}




		public IActionResult AddEmployee()
		{
			
			return View();
		}

		public IActionResult Privacy()
		{
			var deparment = new DepartmentModel()
			{
				Name = "IT",
				Employees = new List<EmployeeModel>()
			};



			var employee = new EmployeeModel()
			{
				En = "025614",
				Name = "Wansao 1",
				Department = "IT",
				Age = 37
			};
			deparment.Employees.Add(employee);



			employee = new EmployeeModel();
			employee.En = "025614";
			employee.Name = "Wansao 2";
			employee.Department = "IT";
			employee.Age = 37;
			deparment.Employees.Add(employee);



			deparment.Employees.Add(new EmployeeModel()
			{
				En = "025614",
				Name = "Wansao 3",
				Department = "IT",
				Age = 37
			});



			deparment.Employees.Add(new EmployeeModel()
			{
				En = "025614",
				Name = "Wansao 4",
				Department = "IT",
				Age = 37
			});
			deparment.Employees.Add(new EmployeeModel()
			{
				En = "025614",
				Name = "Wansao 5",
				Department = "IT",
				Age = 37
			});
			return View(deparment);
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
