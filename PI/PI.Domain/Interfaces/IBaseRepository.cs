using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI.Domain.Interfaces
{
    public interface IBaseRepository<T> where T : class
    {
        void Add(T entity);
        void RemoveById(int entityId);
        T GetById(int entityId);
        IEnumerable<T> GetAll();
        void Update(T entity);
    }
}
