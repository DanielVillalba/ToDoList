using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ToDoList.Models;

namespace ToDoList.DataAccess.Repositories
{
    public class TDListRepository : IRepository<TDList, int>
    {
        public void Add(int id, TDList entity)
        {
            throw new NotImplementedException();
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