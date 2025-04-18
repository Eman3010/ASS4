using IKEA.BLL.Dtos.Departments;
using IKEA.BLL.Dtos.Employees;
using IKEA.BLL.Services.EmplyeeServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Elfie.Diagnostics;

namespace IKEA.PL.Controllers
{
    public class EmployeeController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {

            var Employees = EmployeeServices.GetAllEmployees();

            return View(Employees);
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult create(CreateEmployeeDto  employeeDto)
        {
            if(!ModelState.IsValid)
            
                return View(employeeDto);
           var message=string.Empty;
            try
            {
                var result = EmployeeServices.createEmployee(employeeDto);
                if (result > 0)
                    return RedirectToAction(nameof(Index));
                else
                    message = "Employee is not created";
            }
            catch (Exception Ex)
            {

                Logger.logError(Ex, Ex.Message);
                if (Environment.IsDevelopment())
                    message = Ex.Message;
                   
                
                else
                    message = "An Error Effect of Creation Operation";
                    
            }
            ModelState.AddModelError(string.Empty, message);
            return View(employeeDto);

        }

        public IActionResult Details(int? id)
        {
            if (id is null)
                return BadRequest();

            var Employees = EmployeeServices.GetEmployeeById(id.Value);

            if(Employees is null)
                return NotFound();

            return View(Employees);
        }
    }
}
