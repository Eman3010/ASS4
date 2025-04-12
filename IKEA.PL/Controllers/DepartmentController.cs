using IKEA.BLL.Dtos.Departments;
using IKEA.BLL.Services.DepartmentServices;
using IKEA.DAL.Models.Departments;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Elfie.Diagnostics;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace IKEA.PL.Controllers
{
    public class DepartmentController : Controller
    {
        private IDepartmentServices departmentServices;

        public DepartmentController(IDepartmentServices _departmentServices)
        {
            departmentServices = _departmentServices;
        }
        public IActionResult Index()
        {
            var Department =departmentServices.GetAllDepartment();
            return View(Department);
        }


        [HttpGet]
        public IActionResult Edit( int? id) { 
            if(id is null) { }
            return BadRequest();

            var Department=departmentServices.GetDepartmentById(id.Value);

            if(Department is null) {
                return NotFound();

                var UpdateDepartment = new UpdateDepartmentDto()
                {
                    Id = Department.Id,
                    Name = Department.Name,
                    code = Department.code,
                    CreationDate = Department.CreationDate,
                    Description = Department.Description,
                }; 
                return View(UpdateDepartment);
            }
        }

        public IActionResult Edit(UpdateDepartmentDto departmentDto)
        {

            if (!ModelState.IsValid)
                return View(departmentDto);

            var message = string.Empty;
            try
            {
                var result=departmentServices.UpdateDepartment(departmentDto);
                if (result > 0)
                    return RedirectToAction(nameof(Index));
                else
                    message = "Department is not updated";

            }
            catch (Exception ex)
            {
               
                throw;
            }

            ModelState.AddModelError(string.Empty, message);
            return View(departmentDto);
        }
    }
}
