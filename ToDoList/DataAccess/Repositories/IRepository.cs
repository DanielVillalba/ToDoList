using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.DataAccess.Repositories
{
    //The Generic Interface Repository for Performing Read/Add/Delete operations
    public interface IRepository<TEntity, in TKey> where TEntity : class
    {
        IEnumerable<TEntity> Get();
        TEntity Get(TKey id);
        void Add(TKey id, TEntity entity);
        void Update(TEntity entity);
        void Remove(TEntity entity);
    }
}