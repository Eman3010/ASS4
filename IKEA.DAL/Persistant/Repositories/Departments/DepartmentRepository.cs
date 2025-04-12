using IKEA.DAL.Models.Departments;
using IKEA.DAL.Persistant.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.DAL.Persistant.Repositories.Departments
{
    public class DepartmentRepository : IDepartmentRepository
    {

        private readonly ApplicationDbContextc dbcontext;
        public DepartmentRepository(ApplicationDbContextc contextc) {

            dbcontext = contextc;
        
        }

        public IEnumerable<Department> GetAll()
        {
            return dbcontext.departments.ToList();
        }


        public Department? GetById(int id)
        {
            var Department = dbcontext.departments.Find(id);

            return Department;
        }


        public int Add(Department department)
        {
            dbcontext.departments.Add(department);
            return dbcontext.SaveChanges();
        }

        public int Update(Department department)
        {
            dbcontext.departments.Update(department);
            return dbcontext.SaveChanges();
        }

        public int Delete(Department department)
        {
            dbcontext.departments.Remove(department);
                return dbcontext.SaveChanges();
        }

       
       

      
    }
}
