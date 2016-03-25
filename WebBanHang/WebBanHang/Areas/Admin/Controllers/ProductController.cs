using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanHang.Models;

namespace WebBanHang.Areas.Admin.Controllers
{
    public class ProductController : BaseLogin
    {
        [HttpGet]
        public ActionResult Edit(String id)
        {
            Product model = null;
            try {
                long longid = long.Parse(id);
                model= new Products().GetById(longid);

                //caegory
                IEnumerable<Category> arrcate = new Categories().GetAll();
                ViewBag.cate = arrcate;
            }
            catch
            {
                ViewBag.messagerError = "alert alert-danger";
                ModelState.AddModelError("", "Lỗi đọc từ csdl");
            }
            return View(model);
        }
        
        [HttpPost]
        public ActionResult Edit(Product model)
        { 
            if (ModelState.IsValid == true)
            {
                try
                {
                    IEnumerable<Category> arrcate = new Categories().GetAll();
                    ViewBag.cate = arrcate;
                }
                catch
                {
                    ViewBag.messagerError = "alert alert-danger";
                    ModelState.AddModelError("", "Lỗi đọc từ csdl, không thể hiện thị tên loại sản phẩm");
                }
                try
                {
                    new Products().Update(model);
                    ViewBag.messagerError = "alert alert-success";
                    ModelState.AddModelError("", "Sửa thành công sản phẩm:"+@model.Name);
                }
                catch
                {
                    ViewBag.messagerError = "alert alert-danger";
                    ModelState.AddModelError("", "Lỗi ghi xuống csdl");
                } 
            }
            else
            {
                ViewBag.messagerError = "alert alert-danger";
                ModelState.AddModelError("", "Các ô nhập liệu không được bỏ trống");
            }

            return View(model);
        }

        [HttpGet]
        public ActionResult Create()
        {

            try
            {
                IEnumerable<Category> arrcate = new Categories().GetAll();
                ViewBag.cate = arrcate;
            }
            catch
            {
                ViewBag.messagerError = "alert alert-danger";
                ModelState.AddModelError("", "Lỗi đọc từ csdl, không hiển thị được tên loại sản phẩm");
            }

            return View(new Product());
        }

        [HttpPost]
        public ActionResult Create( Product model)
        {
            //caegory
            if (ModelState.IsValid == true)
            {

                try {
                    // insert 
                    model= new Products().Insert(model);

                    ViewBag.messagerError = "alert alert-success";
                    ModelState.AddModelError("", "Tạo thành công sản phẩm:" + @model.Name);
                }
                catch(SqlException ex)
                {
                    ViewBag.messagerError = "alert alert-danger";
                    ModelState.AddModelError("", "Lỗi đọc từ csdl" );
                }
                catch(Exception ex )
                {
                    ViewBag.messagerError = "alert alert-danger";
                    ModelState.AddModelError("", "Lỗi đọc hình ảnh");
                }

            }
            else
            {
                ViewBag.messagerError = "alert alert-danger";
                ModelState.AddModelError("", "Các ô nhập liệu không được bỏ trống");
            }

            return View(model);
             
        }

        [HttpGet]
        public ActionResult Detail(string id)
        {
            Product model = null;
            try
            {
                IEnumerable<Category> arrcate = new Categories().GetAll();
                ViewBag.cate = arrcate;
            }
            catch
            {
                ViewBag.messagerError = "alert alert-danger";
                ModelState.AddModelError("", "Lỗi đọc từ csdl, không hiển thị được tên loại sản phẩm");
            }
            try {
                model= new Products().GetById(long.Parse(id));
            }
            catch
            {
                ModelState.AddModelError("","Lỗi đọc từ csdl");
            }
            return View(model);
        }




    }
}