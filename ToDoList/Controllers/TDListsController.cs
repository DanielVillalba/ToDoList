﻿using System;
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
        private ToDoContext db = new ToDoContext();

        private IRepository<TDList, int> _db;

        public TDListsController(IRepository<TDList, int> db)
        {
            _db = db;
        }

        // GET: TDLists
        public ActionResult Index()
        {
            IEnumerable<TDList> allLists = _db.Get();
            return View(allLists);
        }

        // GET: TDLists/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            
            TDList tDList = _db.Get(id ?? 0);
            if (tDList == null)
            {
                return HttpNotFound();
            }
            return View(tDList);
        }

        // GET: TDLists/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TDLists/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ListId,Name")] TDList tDList)
        {
            if (ModelState.IsValid)
            {
                _db.Add(tDList.ListId, tDList);
                return RedirectToAction("Index");
            }

            return View(tDList);
        }

        // GET: TDLists/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TDList tDList = await db.ToDoLists.FindAsync(id);
            if (tDList == null)
            {
                return HttpNotFound();
            }
            return View(tDList);
        }

        // POST: TDLists/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "ListId,Name")] TDList tDList)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tDList).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(tDList);
        }

        // GET: TDLists/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TDList tDList = await db.ToDoLists.FindAsync(id);
            if (tDList == null)
            {
                return HttpNotFound();
            }
            return View(tDList);
        }

        // POST: TDLists/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TDList tDList = db.ToDoLists.Find(id);
            if (tDList == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            _db.Remove(tDList);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
