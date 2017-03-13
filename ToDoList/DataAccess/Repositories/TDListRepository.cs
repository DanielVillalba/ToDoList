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
            return db.ToDoLists.ToList();
        }

        public TDList Get(int id)
        {
            return db.ToDoLists.Single(x => x.ListId == id);
        }

        public void Remove(TDList entity)
        {
            var deleteList = db.ToDoLists.Single(x => x.ListId == entity.ListId);
            db.ToDoLists.Remove(deleteList);
            db.SaveChanges();
        }

        public void Update(TDList entity)
        {
            // TODO: create the logic to update DB based
            var deleteList = db.ToDoLists.Single(x => x.ListId == entity.ListId);
            db.ToDoLists.Remove(deleteList);

            db.ToDoLists.Add(entity);

            db.SaveChanges();
        }
    }
}