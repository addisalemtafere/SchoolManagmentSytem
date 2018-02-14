using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using StudentManagmentHighSchool.Context;
using StudentManagmentHighSchool.Models;

namespace StudentManagmentHighSchool.Controllers
{
    public class MarkListsController : Controller
    {
        private HighSchoolStudentContext db = new HighSchoolStudentContext();

        // GET: MarkLists
        public ActionResult Index()
        {
            var markLists = db.MarkLists.Include(m => m.Admission);
            return View(markLists.ToList());
        }

        // GET: MarkLists/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MarkList markList = db.MarkLists.Find(id);
            if (markList == null)
            {
                return HttpNotFound();
            }
            return View(markList);
        }

        // GET: MarkLists/Create
        public ActionResult Create()
        {
            ViewBag.AdmissionId = new SelectList(db.Admissions, "AdmissionId", "AdmissionId");
            return View();
        }

        // POST: MarkLists/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MarkListId,AdmissionId,CourseId,Mark,Semister")] MarkList markList)
        {
            if (ModelState.IsValid)
            {
                db.MarkLists.Add(markList);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.AdmissionId = new SelectList(db.Admissions, "AdmissionId", "AdmissionId", markList.AdmissionId);
            return View(markList);
        }

        // GET: MarkLists/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MarkList markList = db.MarkLists.Find(id);
            if (markList == null)
            {
                return HttpNotFound();
            }
            ViewBag.AdmissionId = new SelectList(db.Admissions, "AdmissionId", "AdmissionId", markList.AdmissionId);
            return View(markList);
        }

        // POST: MarkLists/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MarkListId,AdmissionId,CourseId,Mark,Semister")] MarkList markList)
        {
            if (ModelState.IsValid)
            {
                db.Entry(markList).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.AdmissionId = new SelectList(db.Admissions, "AdmissionId", "AdmissionId", markList.AdmissionId);
            return View(markList);
        }

        // GET: MarkLists/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MarkList markList = db.MarkLists.Find(id);
            if (markList == null)
            {
                return HttpNotFound();
            }
            return View(markList);
        }

        // POST: MarkLists/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MarkList markList = db.MarkLists.Find(id);
            db.MarkLists.Remove(markList);
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
