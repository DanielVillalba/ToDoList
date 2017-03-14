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
using ToDoList.Utils;

namespace ToDoList.Controllers
{
    public class TDListsController : Controller
    {
        private IRepository<TDList, int> _db;
        private ILogger _logging;

        public TDListsController(IRepository<TDList, int> db, ILogger logging)
        {
            _db = db;
            _logging = logging;
        }

        public ActionResult Index()
        {
            _logging.Log(this.GetType().ToString(),"Starting the app.");
            return View();
        }

        public JsonResult getAllTasks()
        {
            _logging.Log(this.GetType().ToString(), "Getting all tasks.");
            IEnumerable<TDList> allTasks = _db.Get();
            return Json(allTasks, JsonRequestBehavior.AllowGet);
        }

        public string addTask(TDList task)
        {
            _logging.Log(this.GetType().ToString(), "Adding task.");
            if (task != null)
            {
                _db.Add(task.ListId, task);
                _logging.Log(this.GetType().ToString(), "Task added.");
                return "Task Added";
            }
            else
            {
                _logging.Log(this.GetType().ToString(), "Invalid task to add.");
                return "Invalid Task";
            }
        }

        public string deleteTask(int id)
        {
            _logging.Log(this.GetType().ToString(), "Deleting task.");
            TDList tDList = _db.Get(id);
            _db.Remove(tDList);
            _logging.Log(this.GetType().ToString(), "Task deleted.");
            return "Task Deleted";
        }

        public string updateTask(TDList task)
        {
            _logging.Log(this.GetType().ToString(), "Updating task.");
            if (task != null)
            {
                _db.Update(task);
                _logging.Log(this.GetType().ToString(), "Task updated.");
                return "Task Updated";
            }
            else
            {
                _logging.Log(this.GetType().ToString(), "Invalid task to update.");
                return "Invalid Task";
            }
        }
    }
}
