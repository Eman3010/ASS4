using IKEA.BLL.Dtos.Departments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.BLL.Services.DepartmentServices
{
    public interface IDepartmentServices
    {
        IEnumerable<DepartmentDto> GetAllDepartment();

        DepartmentDetailsDto GetDepartmentById(int id);

        int CreateDepartment(CreateDeprtmentDto deprtmentDto);

        int UpdateDepartment(UpdateDepartmentDto departmentDto);

        bool DeleteDepartment(int id);
    }
}
