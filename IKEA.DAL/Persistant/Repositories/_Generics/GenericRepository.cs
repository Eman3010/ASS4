using IKEA.DAL.Models;
using IKEA.DAL.Models.Employees;
using IKEA.DAL.Persistant.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.DAL.Persistant.Repositories._Generics
{
    public class GenericRepository<T> : IGenericRepository<T> where T:ModelBase
    {
        private readonly ApplicationDbContextc dbcontext;
        public GenericRepository(ApplicationDbContextc contextc)
        {

            dbcontext = contextc;

        }

        public IEnumerable<T> GetAll()
        {
            return dbcontext.Set<T>().ToList();
        }


        public T? GetById(int id)
        {
            var item = dbcontext.Set<T>().Find(id);

            return item;
        }


        public int Add(T item)
        {
            dbcontext.Set<T>().Add(item);
            return dbcontext.SaveChanges();
        }

        public int Update(T item)
        {
            dbcontext.Set<T>().Update(item);
            return dbcontext.SaveChanges();
        }

        public int Delete(T item)
        {
            dbcontext.Set<T>().Remove(item);
            return dbcontext.SaveChanges();
        }

    }
}
