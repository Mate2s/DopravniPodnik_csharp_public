using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebDopravniPodnik.CustomerService1;
using WebDopravniPodnik.Models;

namespace WebDopravniPodnik.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {

            Login login = new Login();
            return View(login);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(Login objUser)
        {
            if (ModelState.IsValid)
            {
                CustomerService1.CusomerServiceClient sc = new CusomerServiceClient();
                var user = sc.Login(objUser.LoginName, objUser.Password);
                if (user != null)
                {
                    Session["UserID"] = user._id.ToString();
                    return RedirectToAction("Index","Home");
                }
            }
            return View(objUser);
        }

        public ActionResult Logout()
        {
            Session["UserID"] = null;

            return RedirectToAction("Index", "Login");
        }
    }
}