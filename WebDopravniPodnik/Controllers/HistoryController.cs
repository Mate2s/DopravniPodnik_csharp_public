using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebDopravniPodnik.Models;

namespace WebDopravniPodnik.Controllers
{
    public class HistoryController : Controller
    {
        // GET: History
        public ActionResult Index()
        {
            var a = CustomerJourney.HistoryOfJourneys(int.Parse(Session["UserID"].ToString()));
            return View(a);
        }


        public ActionResult EditComment(CustomerJourney items)
        {
            throw new NotImplementedException();
        }
    }
}