using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcMovie.Models;

namespace MvcMovie.Controllers
{ 
    public class EmployeesController : Controller
    {
        private MovieDbContext db = new MovieDbContext();

        //
        // GET: /Employees/

        public ViewResult Index()
        {
            return View(db.Employees.ToList());
        }

        //
        // GET: /Employees/Details/5

        public ViewResult Details(int id)
        {
            Employee employee = db.Employees.Find(id);
            return View(employee);
        }

        //
        // GET: /Employees/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Employees/Create

        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                db.Employees.Add(employee);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(employee);
        }
        
        //
        // GET: /Employees/Edit/5
 
        public ActionResult Edit(int id)
        {
            Employee employee = db.Employees.Find(id);
            return View(employee);
        }

        //
        // POST: /Employees/Edit/5

        [HttpPost]
        public ActionResult Edit(Employee employee)
        {
            if (ModelState.IsValid)
            {
                db.Entry(employee).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(employee);
        }

        //
        // GET: /Employees/Delete/5
 
        public ActionResult Delete(int id)
        {
            Employee employee = db.Employees.Find(id);
            return View(employee);
        }

        //
        // POST: /Employees/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            Employee employee = db.Employees.Find(id);
            db.Employees.Remove(employee);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}