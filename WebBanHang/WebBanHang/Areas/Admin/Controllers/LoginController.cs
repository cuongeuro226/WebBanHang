using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanHang.Models;

namespace WebBanHang.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        ShopWallpaperEntities db = new ShopWallpaperEntities();
        // GET: Admin/Login
        public ActionResult Index()
        {

            return View();

        }
        [HttpPost]
        public ActionResult Index( Account model)
        {
            string common = "login";
            var res = db.Accounts.Where(x => x.Id == model.Id).SingleOrDefault();
            if (res!= null && res.Password== model.Password)
            {
                Session.Add(common, model.Id);
                return RedirectToAction("Index", "HomeAdmin");
            }
            return RedirectToAction("Index", "Login"); 

        }

        public ActionResult logout()
        {
             
             
                Session.Remove("login");
            return RedirectToAction("Index", "Login");

        }
    }
}