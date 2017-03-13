using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ToDoList.Context;
using ToDoList.Models;
using ToDoList.DataAccess.Repositories;

namespace ToDoList.Controllers
{
    public class TDListsController : Controller
    {
        private IRepository<TDList, int> _db;

        public TDListsController(IRepository<TDList, int> db)
        {
            _db = db;
        }

        public ActionResult Index()
        {
            return View();
        }

        public JsonResult getAllTasks()
        {
            IEnumerable<TDList> allTasks = _db.Get();
            return Json(allTasks, JsonRequestBehavior.AllowGet);
        }

        public string addTask(TDList task)
        {
            if (task != null)
            {
                _db.Add(task.ListId, task);
                return "Task Added";
            }
            else
            {
                return "Invalid Task";
            }
        }

        public string deleteTask(int id)
        {
                TDList tDList = _db.Get(id);
                _db.Remove(tDList);
                return "Employee Deleted";
        }

        public string updateTask(TDList task)
        {
            if (task != null)
            {
                _db.Update(task);
                return "Employee Updated";
            }
            else
            {
                return "Invalid Employee";
            }
        }
    }
}
