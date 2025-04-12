using IKEA.DAL.Models;
using IKEA.DAL.Models.Departments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.DAL.Persistant.Repositories._Generics
{
    public  interface IGenericRepository<T> where T :ModelBase
    {
        IEnumerable<T> GetAll();

        T? GetById(int id);

        int Add(T Entity);

        int Update(T Entity);

        int Delete(T Entity);

    }
}
