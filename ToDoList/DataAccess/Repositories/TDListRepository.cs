using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ToDoList.Context;
using ToDoList.Models;

namespace ToDoList.DataAccess.Repositories
{
    public class TDListRepository : IRepository<TDList, int>
    {
        // using Unity dependency injection as property in order to get the DBcontext object
        [Dependency]
        public ToDoContext db { get; set; }

        public void Add(int id, TDList entity)
        {
            db.ToDoLists.Add(entity);
            db.SaveChanges();
            
        }

        public IEnumerable<TDList> Get()
        {
            throw new NotImplementedException();
        }

        public TDList Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(TDList entity)
        {
            throw new NotImplementedException();
        }

        public void Update(TDList entity)
        {
            throw new NotImplementedException();
        }
    }
}