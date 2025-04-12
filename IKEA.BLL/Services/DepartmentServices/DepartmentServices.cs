using IKEA.BLL.Dtos.Departments;
using IKEA.DAL.Models.Departments;
using IKEA.DAL.Persistant.Repositories.Departments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.BLL.Services.DepartmentServices
{
    public class DepartmentServices : IDepartmentServices
    {
        private DepartmentRepository Repository;
        public DepartmentServices(DepartmentRepository _repository)
        {

            Repository = _repository;
        }

        public IEnumerable<DepartmentDto> GetAllDepartment()
        {
            var Departments = Repository.GetAll();
            List<DepartmentDto> departmentDtos = new List<DepartmentDto>();
            foreach (var dept in Departments)
            {
                DepartmentDto departmentDto = new DepartmentDto()
                {
                    Id = dept.Id,
                    Name = dept.Name,
                    code = dept.code,
                    CreationDate = dept.CreationDate,
                };
                departmentDtos.Add(departmentDto);
            }
            return departmentDtos;
        }

        public DepartmentDetailsDto GetDepartmentById(int id)
        {
            var Department = Repository.GetById(id);

            if (Department is not null)
            {
                return new DepartmentDetailsDto()
                {
                    Id = Department.Id,
                    Name = Department.Name,
                    code = Department.code,
                    CreationDate = Department.CreationDate,
                    createdby = Department.createdby,
                    Description = Department.Description,
                    createdon = Department.createdon,
                    LastModifiedBy = Department.LastModifiedOn,
                    LastModifiedOn = Department.LastModifiedOn,
                };
            }
            return null;

        }


        public int CreateDepartment(CreateDeprtmentDto deprtmentDto)
        {
            var CreateDepartment = new Department()
            {
                code = deprtmentDto.code,
                Name = deprtmentDto.Name,
                Description = deprtmentDto.Description,
                CreationDate = deprtmentDto.CreationDate,
                createdby = 1,
                createdon = DateTime.Now,
                LastModifiedBy = 1,

            };

            return Repository.Add(CreateDepartment);
        }

        public int UpdateDepartment(UpdateDepartmentDto departmentDto)
        {
            var UpdateDepartment = new Department()
            {

                Id = departmentDto.Id,
                Name = departmentDto.Name,
                code = departmentDto.code,
                CreationDate = departmentDto.CreationDate,
                Description = departmentDto.Description,
            };

            return Repository.Update(UpdateDepartment);
        }

        public bool DeleteDepartment(int id)
        {
            var Employee = Repository.GetById(id);
            int Result = 0;
            if (Employee is not null)
                Result = Repository.Delete(Employee);
            if (Result > 0)
                return true;
            else
                return false;
        }
    }
}

        

       

        
    

