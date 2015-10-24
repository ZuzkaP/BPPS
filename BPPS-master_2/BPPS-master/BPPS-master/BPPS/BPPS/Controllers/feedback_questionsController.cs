using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BPPS.Models;

namespace BPPS.Controllers
{
    public class feedback_questionsController : Controller
    {
        private Entities db = new Entities();

        // GET: feedback_questions
        public ActionResult Index()
        {
            return View(db.feedback_questions.ToList());
        }

        // GET: feedback_questions/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            feedback_questions feedback_questions = db.feedback_questions.Find(id);
            if (feedback_questions == null)
            {
                return HttpNotFound();
            }
            return View(feedback_questions);
        }

        // GET: feedback_questions/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: feedback_questions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "question_id,feedback_id,result,comment")] feedback_questions feedback_questions)
        {
            if (ModelState.IsValid)
            {
                db.feedback_questions.Add(feedback_questions);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(feedback_questions);
        }

        // GET: feedback_questions/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            feedback_questions feedback_questions = db.feedback_questions.Find(id);
            if (feedback_questions == null)
            {
                return HttpNotFound();
            }
            return View(feedback_questions);
        }

        // POST: feedback_questions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "question_id,feedback_id,result,comment")] feedback_questions feedback_questions)
        {
            if (ModelState.IsValid)
            {
                db.Entry(feedback_questions).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(feedback_questions);
        }

        // GET: feedback_questions/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            feedback_questions feedback_questions = db.feedback_questions.Find(id);
            if (feedback_questions == null)
            {
                return HttpNotFound();
            }
            return View(feedback_questions);
        }

        // POST: feedback_questions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            feedback_questions feedback_questions = db.feedback_questions.Find(id);
            db.feedback_questions.Remove(feedback_questions);
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
