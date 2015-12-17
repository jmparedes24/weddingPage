using System.Collections.Generic;

namespace CommoProject.Interfaces
{
    public interface IRepository<T> where T: class
    {
        IEnumerable<T> List { get; }
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        T FindById(int id);
    }
}
