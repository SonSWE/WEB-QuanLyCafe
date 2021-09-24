using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebQuanLyQuanCafe.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        [HttpGet]
        public ActionResult Login()
        {
            if (Session["usernameLogin"] != null)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            if(username == "admin" && password == "admin")
            {
                Session["usernameLogin"] = username;
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
    }
}