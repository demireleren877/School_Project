using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School_Project.DataAccesLayer
{
    public interface IGenericRepository<T> where T: class, new()
    {
        void Add(T entity);
        void Update(T entity);
        void Remove(T entity);
        List<T> GetList();
        T Get(int id);


    }
}
