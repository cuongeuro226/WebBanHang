using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanHang.Models;

namespace WebBanHang.Areas.Admin.Controllers
{
    public class HomeAdminController : Controller
    {
        // GET: Admin/HomeAdmin
        // GET: Admin/HomeAdmin
        public ActionResult Index()
        {
            IEnumerable<Product> model = new Products().GetAll();
            return View(model);
        }
        [HttpGet]
        public ActionResult Edit(String id)
        {
            return View();
        }    }
}