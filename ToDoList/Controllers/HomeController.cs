using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ToDoList.DataAccess.Repositories;
using ToDoList.Models;
using ToDoList.Utils;

namespace ToDoList.Controllers
{
    public class HomeController : Controller
    {
        private IRepository<TDList, int> _db;
        private ILogger _logger;

        public HomeController(IRepository<TDList, int> db, ILogger logger)
        {
            _db = db;
            _logger = logger;
        }

        public ActionResult Index()
        {
            // TEST DATA
            //_logger.Log("*********************************************");
            //var test = new TDList
            //{
            //    ListId = 1,
            //    Name = "Test list",
            //    ToDoes = new List<ToDo>
            //    {
            //        new ToDo
            //        {
            //            Id = 1,
            //            Description="Test Todo",
            //            IsDone = false,
            //        }
            //    }
            //};
            //_db.Add(1, test);

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}