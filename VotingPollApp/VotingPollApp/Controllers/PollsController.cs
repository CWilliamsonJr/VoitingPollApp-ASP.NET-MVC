using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VotingPollApp.Controllers
{
    public class PollsController : Controller
    {
        // GET: Polls
        public ActionResult Index()
        {
            return View();
        }

        // GET: Polls/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Polls/Create
        public ActionResult Make()
        {
            return View();
        }

        // POST: Polls/Create
        [HttpPost]
        public ActionResult Make(FormCollection collection)
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

        // GET: Polls/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Polls/Edit/5
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

        // GET: Polls/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Polls/Delete/5
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

        // GET: EditPoll
        //public ActionResult Edit() // View for editing the poll
        //{
        //    return View();
        //}

        //// GET: ViewResults
        //public ActionResult Results() // View for seeing the results
        //{
        //    return View();
        //}
        
    }
}
