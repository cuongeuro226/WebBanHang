using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanHang.Models;

namespace WebBanHang.Areas.Admin.Controllers
{
    public class OrderController : BaseLogin
    {
        // GET: Admin/Order
        public ActionResult Index()
        {
            IEnumerable<WebBanHang.Models.Order> model= null;
            try
            {
                model = new Orderss().GetAll();
            }
            catch
            {
                ModelState.AddModelError("","Lỗi không đọc được csdl");
            }
            return View(model);
        }

        public ActionResult Detail(String id)
        {



             WebBanHang.Models.Order  model = null;
            try
            {
                model = new Orderss().GetById(long.Parse(id));

            }
            catch
            {
                ViewBag.messagerError = "alert alert-danger";
                ModelState.AddModelError("", "Lỗi không đọc được csdl");
            }
            return View(model);
        }
        [HttpPost]
        public ActionResult Detail(WebBanHang.Models.Order model)
        { 
             
            try
            {
                new Orderss().Update(model);
                // Edit
                ViewBag.messagerError = "alert alert-success";
                ModelState.AddModelError("", "Lưu thành công hóa đơn : "+ model.Id);
            }
            catch
            {
                ViewBag.messagerError = "alert alert-danger";
                ModelState.AddModelError("", "Lỗi không lưu được csdl");
            }
            return View(model);
        }
        [ChildActionOnly]
        public ActionResult DetailOrder(String id)
        {
           IEnumerable<DetailOrder> model = null;
            try
            {
                model = new DetailOrderss().GetById(long.Parse(id));
                // Edit 
                ViewBag.messagerError = "alert alert-success";
                ModelState.AddModelError("", "Lưu thành công hóa đơn : " + id);
            }
            catch
            {
                ViewBag.messagerError = "alert alert-danger";
                ModelState.AddModelError("", "Lỗi không lưu được csdl");
            }
            return PartialView(model);
        }



    }
}