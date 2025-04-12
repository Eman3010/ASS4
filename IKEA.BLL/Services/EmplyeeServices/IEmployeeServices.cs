using IKEA.BLL.Dtos.Departments;
using IKEA.BLL.Dtos.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.BLL.Services.EmplyeeServices
{
    public  interface IEmployeeServices
    {
        IEnumerable<EmployeeDto> GetAllEmployee();

        EmployeeDetailsDto GetEmployeeById(int id);

        int CreateEmployee(CreateEmployeeDto  employeeDto);

        int UpdateEmployee(UpdateEmployeeDto employeeDto);

        bool DeleteEmployee(int id);
    }
}
