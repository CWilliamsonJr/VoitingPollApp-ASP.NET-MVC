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

        // GET: EditPoll
        public ActionResult Edit()
        {
            return View();
        }

        // GET: ViewResults
        public ActionResult Results()
        {
            return View();
        }
        // GET: MakePolls
        public ActionResult Make()
        {
            return View();
        }
    }
}