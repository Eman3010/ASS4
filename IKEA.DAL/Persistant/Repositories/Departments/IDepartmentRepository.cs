﻿using IKEA.DAL.Models.Departments;
using IKEA.DAL.Persistant.Repositories._Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.DAL.Persistant.Repositories.Departments
{
    public interface IDepartmentRepository:IGenericRepository<Department>
    {
       
    }
}
