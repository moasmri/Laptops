using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Laptops.Models;

namespace Laptops.Controllers
{
    [Authorize]
    public class CategorysController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Categorys
        public ActionResult Index()
        {
            return View(db.Categorys.ToList());
        }

        // GET: Categorys/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Categorys categorys = db.Categorys.Find(id);
            if (categorys == null)
            {
                return HttpNotFound();
            }
            return View(categorys);
        }

        // GET: Categorys/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Categorys/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,CategoryName,CategoryDesc")] Categorys categorys)
        {
            if (ModelState.IsValid)
            {
                db.Categorys.Add(categorys);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(categorys);
        }

        // GET: Categorys/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Categorys categorys = db.Categorys.Find(id);
            if (categorys == null)
            {
                return HttpNotFound();
            }
            return View(categorys);
        }

        // POST: Categorys/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,CategoryName,CategoryDesc")] Categorys categorys)
        {
            if (ModelState.IsValid)
            {
                db.Entry(categorys).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(categorys);
        }

        // GET: Categorys/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Categorys categorys = db.Categorys.Find(id);
            if (categorys == null)
            {
                return HttpNotFound();
            }
            return View(categorys);
        }

        // POST: Categorys/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Categorys categorys = db.Categorys.Find(id);
            db.Categorys.Remove(categorys);
            db.SaveChanges();
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
