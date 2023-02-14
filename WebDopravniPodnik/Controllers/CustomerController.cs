using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebDopravniPodnik.CustomerService1;

namespace WebDopravniPodnik.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            CustomerService1.CusomerServiceClient sc = new CusomerServiceClient();
            var item =Models.Customer.CastTo(sc.Load(int.Parse(Session["UserID"].ToString())));
            return View(item);
        }

        public ActionResult Edit(int id)
        {
            throw new NotImplementedException();
        }
    }
}