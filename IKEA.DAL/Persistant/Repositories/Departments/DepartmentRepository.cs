﻿using IKEA.DAL.Models.Departments;
using IKEA.DAL.Persistant.Data;
using IKEA.DAL.Persistant.Repositories._Generics;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.DAL.Persistant.Repositories.Departments
{
    public class DepartmentRepository :GenericRepository<Department> ,IDepartmentRepository
    {

        private readonly ApplicationDbContextc dbcontext;
        public DepartmentRepository (ApplicationDbContextc contextc):base(contextc)
        {

            dbcontext = contextc;

        }



    }
}
