using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using WebBanHang.Models;

namespace WebBanHang.Areas.Admin.Controllers
{
    public class HomeAdminController : BaseLogin
    {

        public ActionResult Index()
        {
            IEnumerable<Product> model = null;
            try {

                IEnumerable<Category> cate = new Categories().GetAll();
            
                ViewBag.cate = cate;
                model=new Products().GetAll();
            }
            catch
            {
                ModelState.AddModelError("","lỗi đọc từ csdl");
            }

            return View(model);
        }       


        public JsonResult Search(String type ="")
        {
            try
            {

                IEnumerable<Category> cate = new Categories().GetAll();
                ViewBag.cate = cate;
                // sua lai thanh get search
                var model = new Products().GetAll();
                long a = model.First().Category;
                JsonResult res = new JsonResult();
                String jsonString = new JavaScriptSerializer().Serialize(model);
                res.Data = jsonString;
                
                


                return res;
            }
            catch(Exception e)
            {
                ModelState.AddModelError("", "lỗi đọc từ csdl");
            }

            return new JsonResult();
            
                
        }
           
        



    }
}