using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ToDoList.Context;

namespace ToDoList.Controllers
{
    public class TDListController : Controller
    {
        ToDoContext DB = new ToDoContext();
        
        // GET: TDList
        public ActionResult Index()
        {
            return View(DB.ToDoLists.ToList());
        }

        // GET: TDList/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TDList/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TDList/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: TDList/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TDList/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: TDList/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TDList/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
