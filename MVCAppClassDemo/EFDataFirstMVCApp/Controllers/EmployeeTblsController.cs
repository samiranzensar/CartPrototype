using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EFDataFirstMVCApp;

namespace EFDataFirstMVCApp.Controllers
{
    public class EmployeeTblsController : Controller
    {
        private ZensarTrainingEntities db = new ZensarTrainingEntities();

        // GET: EmployeeTbls
        public ActionResult Index()
        {
            var employeeTbls = db.EmployeeTbls.Include(e => e.DepartmentTbl);
            return View(employeeTbls.ToList());
        }

        // GET: EmployeeTbls/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmployeeTbl employeeTbl = db.EmployeeTbls.Find(id);
            if (employeeTbl == null)
            {
                return HttpNotFound();
            }
            return View(employeeTbl);
        }

        // GET: EmployeeTbls/Create
        public ActionResult Create()
        {
            ViewBag.deptId = new SelectList(db.DepartmentTbls, "DeptId", "DeptName");
            return View();
        }

        // POST: EmployeeTbls/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "empId,empName,empSal,deptId")] EmployeeTbl employeeTbl)
        {
            if (ModelState.IsValid)
            {
                db.EmployeeTbls.Add(employeeTbl);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.deptId = new SelectList(db.DepartmentTbls, "DeptId", "DeptName", employeeTbl.deptId);
            return View(employeeTbl);
        }

        // GET: EmployeeTbls/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmployeeTbl employeeTbl = db.EmployeeTbls.Find(id);
            if (employeeTbl == null)
            {
                return HttpNotFound();
            }
            ViewBag.deptId = new SelectList(db.DepartmentTbls, "DeptId", "DeptName", employeeTbl.deptId);
            return View(employeeTbl);
        }

        // POST: EmployeeTbls/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "empId,empName,empSal,deptId")] EmployeeTbl employeeTbl)
        {
            if (ModelState.IsValid)
            {
                db.Entry(employeeTbl).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.deptId = new SelectList(db.DepartmentTbls, "DeptId", "DeptName", employeeTbl.deptId);
            return View(employeeTbl);
        }

        // GET: EmployeeTbls/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmployeeTbl employeeTbl = db.EmployeeTbls.Find(id);
            if (employeeTbl == null)
            {
                return HttpNotFound();
            }
            return View(employeeTbl);
        }

        // POST: EmployeeTbls/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EmployeeTbl employeeTbl = db.EmployeeTbls.Find(id);
            db.EmployeeTbls.Remove(employeeTbl);
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
