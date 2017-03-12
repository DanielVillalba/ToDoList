using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ToDoList.DataAccess.Repositories;
using ToDoList.Models;

namespace ToDoList.Controllers
{
    public class HomeController : Controller
    {
        readonly log4net.ILog logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private IRepository<TDList, int> _db;

        public HomeController(IRepository<TDList, int> db)
        {
            _db = db;
        }

        public ActionResult Index()
        {
            // TEST DATA

            var test = new TDList
            {
                ListId = 1,
                Name = "Test list",
                ToDoes = new List<ToDo>
                {
                    new ToDo
                    {
                        Id = 1,
                        Description="Test Todo",
                        IsDone = false,
                    }
                }
            };
            _db.Add(1, test);

            logger.Debug("Starting the Index action");
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