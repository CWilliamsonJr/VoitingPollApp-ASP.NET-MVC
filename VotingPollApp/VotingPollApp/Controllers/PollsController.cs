﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using VotingPollApp.Models;

namespace VotingPollApp.Controllers
{
    public class PollsController : Controller
    {
        private VotingAppEntities db = new VotingAppEntities();

        // GET: Polls
        public ActionResult Index()
        {
            var polls = db.Polls.Include(p => p.Question).Include(p => p.User);
            return View(polls.ToList());
        }

        // GET: Polls/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Poll poll = db.Polls.Find(id);
            if (poll == null)
            {
                return HttpNotFound();
            }
            return View(poll);
        }

        // GET: Polls/Create
        public ActionResult Create()
        {
            ViewBag.Question_Id = new SelectList(db.Questions, "Id", "Question1");
            ViewBag.User_Id = new SelectList(db.Users, "Id", "User_Name");
            return View();
        }

        // POST: Polls/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Choice,Votes,User_Id,Question_Id")] Poll poll)
        {
            if (ModelState.IsValid)
            {
                db.Polls.Add(poll);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Question_Id = new SelectList(db.Questions, "Id", "Question1", poll.Question_Id);
            ViewBag.User_Id = new SelectList(db.Users, "Id", "User_Name", poll.User_Id);
            return View(poll);
        }

        // GET: Polls/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Poll poll = db.Polls.Find(id);
            if (poll == null)
            {
                return HttpNotFound();
            }
            ViewBag.Question_Id = new SelectList(db.Questions, "Id", "Question1", poll.Question_Id);
            ViewBag.User_Id = new SelectList(db.Users, "Id", "User_Name", poll.User_Id);
            return View(poll);
        }

        // POST: Polls/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Choice,Votes,User_Id,Question_Id")] Poll poll)
        {
            if (ModelState.IsValid)
            {
                db.Entry(poll).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Question_Id = new SelectList(db.Questions, "Id", "Question1", poll.Question_Id);
            ViewBag.User_Id = new SelectList(db.Users, "Id", "User_Name", poll.User_Id);
            return View(poll);
        }

        // GET: Polls/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Poll poll = db.Polls.Find(id);
            if (poll == null)
            {
                return HttpNotFound();
            }
            return View(poll);
        }

        // POST: Polls/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Poll poll = db.Polls.Find(id);
            db.Polls.Remove(poll);
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
