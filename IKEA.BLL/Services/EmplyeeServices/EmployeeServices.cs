using IKEA.BLL.Dtos.Employees;
using IKEA.DAL.Common.Enums;
using IKEA.DAL.Persistant.Repositories.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.BLL.Services.EmplyeeServices
{
    public class EmployeeServices:IEmployeeServices
    {

        private readonly IEmployeeRepository Repository;
        public EmployeeServices(IEmployeeRepository _repository) {
        
        Repository = _repository;
        }


        public IEnumerable<EmployeeDto> GetAllEmployee()
        {
            return Repository.GetAll().Where(E=>E.IsDeleted== false).Select(E=> new EmployeeDto()
            {
                Id=E.Id,
                Name=E.Name,
                Age=E.Age,
                Salary=E.Salary,
                IsActive=E.IsActive,
                Email=E.Email,
                Gender=nameof(E.Gender),
                EmployeeType=nameof(E.EmployeeType),  
            }).ToList();


        }

        public EmployeeDetailsDto GetEmployeeById(int id)
        {
            var employee = Repository.GetById(id);

            if (employee is not null) {
                return new EmployeeDetailsDto()
                {
                    Id= employee.Id,
                    Name = employee.Name,
                    Address=employee.Address,
                    Age = employee.Age,
                    Salary=employee.Salary,
                    IsActive=employee.IsActive,
                    Email=employee.Email,
                    PhoneNumber=employee.PhoneNumber,
                    HiringDate=employee.HiringDate,
                    Gender=employee.Gender,
                    EmployeeType=employee.EmployeeType,

                    LastModifiedBy= employee.LastModifiedBy,
                    LastModifiedOn= employee.LastModifiedOn,
                    createdby=employee.createdby,
                    createdon=employee.createdon,

                };

            
            }
            return null;
        } 

        public int CreateEmployee(CreateEmployeeDto employeeDto)
        {
            var Employee = new Employee()
            {
                name = employeeDto.Name,
                Address = employeeDto.Address,
                Age = employeeDto.Age,
                Salary = employeeDto.Salary,
                IsActive = employeeDto.IsActive,
                Email = employeeDto.Email,
                PhoneNumber = employeeDto.PhoneNumber,
                hiringdate = employeeDto.HiringDate,
                Gender = employeeDto.Gender,
                EmployeeType = employeeDto.EmployeeType,

                createdby = 1,
                lastmodifiedby = 1,
                lastmodifiedon = DateTime.Now,
                createdon = DateTime.Now,
            };
            return Repository.Add(Employee);
        }

        public int UpdateEmployee(UpdateEmployeeDto employeeDto)
        {

            var Employee = new Employee()
            {
                ID= employeeDto.Id,
                name = employeeDto.Name,
                Address = employeeDto.Address,
                Age = employeeDto.Age,
                Salary = employeeDto.Salary,
                IsActive = employeeDto.IsActive,
                Email = employeeDto.Email,
                PhoneNumber = employeeDto.PhoneNumber,
                hiringdate = employeeDto.HiringDate,
                Gender = employeeDto.Gender,
                EmployeeType = employeeDto.EmployeeType,
                lastmodifiedby = 1,
                lastmodifiedon = DateTime.Now,
            };
            return Repository.Update(Employee);
        }


        public bool DeleteEmployee(int id)
        {
          
        }

       

       
    }
}
