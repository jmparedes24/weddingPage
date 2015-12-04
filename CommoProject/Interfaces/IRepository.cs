using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommonProject.Interfaces
{
    public interface IRepository<T> where T: class
    {
        IEnumerable<T> List { get; }
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        T FindById(int Id);
    }
}
