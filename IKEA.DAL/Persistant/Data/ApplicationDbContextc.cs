using IKEA.DAL.Models.Departments;
using IKEA.DAL.Models.Employees;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.DAL.Persistant.Data
{
    public class ApplicationDbContextc:DbContext
    {

        public ApplicationDbContextc(DbContextOptions options):base(options) { }    


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
        public DbSet<Department> departments {  get; set; }

        public DbSet<Employee>  Employees { get; set; } 
    }
}
