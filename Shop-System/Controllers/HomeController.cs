using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Shop_System.Models;
using Shop_System.BLL;

namespace Shop_System.Controllers
{
    public class HomeController : Controller
    {
        private ShopSystemEntities db = new ShopSystemEntities();

        //home page
        public ActionResult Index()
        {
            var items = db.ITEMS.ToList();
            return View(items);
        }

        
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(USERS model)
        {
            if (ModelState.IsValid)
            {
                db.USERS.Add(model);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                USERS person = UserBLL.ValidateUser(model.USER_NAME, model.U_PASSWORD);
                if (person != null)
                {
                    return RedirectToAction("IndexRW", "Home");
                }
            }
                ModelState.AddModelError("Error_PersonLogin", "username or password is wrong.");
                return View();
            }

        public ActionResult IndexRW()
        {
            var items = db.ITEMS.ToList();
            return View(items);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}