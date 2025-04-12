using IKEA.DAL.Models.Departments;
using IKEA.DAL.Models.Employees;
using IKEA.DAL.Persistant.Data;
using IKEA.DAL.Persistant.Repositories._Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.DAL.Persistant.Repositories.Employees
{
    public class EmployeeRepository :GenericRepository<Employee>,IEmployeeRepository
    {
        private readonly ApplicationDbContextc dbcontext;
        public EmployeeRepository(ApplicationDbContextc contextc):base(contextc) 
        {

            dbcontext = contextc;

        }

        
    }
}
