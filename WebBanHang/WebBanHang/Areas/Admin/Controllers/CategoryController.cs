using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanHang.Models;

namespace WebBanHang.Areas.Admin.Controllers
{
    public class CategoryController : BaseLogin
    {
        // GET: Admin/Category
        public ActionResult Index()
        {
            IEnumerable<WebBanHang.Models.Category> model= null;
            try {
                model = new Categories().GetAll();
                
            }
            catch
            {
                ViewBag.classmessage = "alert alert-danger";
                ModelState.AddModelError("", "Lỗi quá trình đọc từ csdl");
            }
            return View(model);
        }
        public ActionResult Edits(String id)
        {
            WebBanHang.Models.Category model = null;
            try {
               model = new Categories().GetById(long.Parse(id));
            }
            catch
            {
                ModelState.AddModelError("", "Lỗi quá trình đọc từ csdl");
            }

            return View(model);

        }
        [HttpPost]
        public ActionResult Edits(Category model)
        {
            // 
            if(ModelState.IsValid)
            {
                try
                {
                    new Categories().Update(model);
                    ViewBag.classmessage = "alert alert-success";
                    ModelState.AddModelError("", "Sửa thành công loại sản phẩm:"+ model.Name);
                }
                catch
                {
                    ViewBag.classmessage = "alert alert-danger";
                    ModelState.AddModelError("", "Lỗi quá trình lưu xuống csdl");
                }
            }
            else
            {

                ViewBag.classmessage = "alert alert-danger";
                ModelState.AddModelError("", "Các ô nhập liệu không được bỏ trống");
            }

            return View(model);
        }
        public ActionResult Create( )
        {
             

            return View( );

        }
        [HttpPost]
        public ActionResult Create(Category model)
        {
            // 
            if (ModelState.IsValid)
            {
                try
                {
                    model= new Categories().Insert(model);
                    ViewBag.classmessage = "alert alert-success";
                    ModelState.AddModelError("", "Lưu thành công loại sản phẩm:" +model.Name);
                }
                catch
                {
                    ViewBag.classmessage = "alert alert-danger";
                    ModelState.AddModelError("", "Lỗi quá trình lưu xuống csdl");
                }
            }
            else
            {

                ViewBag.classmessage = "alert alert-danger";
                ModelState.AddModelError("", "Các ô nhập liệu không được bỏ trống");
            }

            return View(model);
        }

        public ActionResult Delete(String id)
        {
            WebBanHang.Models.Category model = null;
            try
            {
                model = new Categories().GetById(long.Parse(id));
                new Categories().Delete(model);
            }
            catch
            {
                ViewBag.classmessage = "alert alert-danger";
                ModelState.AddModelError("", "Lỗi quá trình đọc từ csdl");
            }


            //seccess
            ViewBag.classmessage = "alert alert-success";
            ModelState.AddModelError("", "Xóa thành công : mã loại sp:"+id);
            return View(model);

        }

    }
}