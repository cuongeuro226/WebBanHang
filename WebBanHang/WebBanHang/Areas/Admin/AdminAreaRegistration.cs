using System.Web.Mvc;

namespace WebBanHang.Areas.Admin
{
    public class AdminAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Admin_default",
                "Admin",
                new { action = "Index", Controller="HomeAdmin", id = UrlParameter.Optional }
            ); 
            context.MapRoute(
               "Admin_edit",
               "Admin/EditProduct/{id}",
               new { action = "Edit", Controller = "Product", id = UrlParameter.Optional }
           );
            context.MapRoute(
              "Admin_detail",
              "Admin/DetailProduct/{id}", 
               new { action = "Detail", Controller = "Product", id = UrlParameter.Optional }
          );
            context.MapRoute(
               "Admin_create",
               "Admin/CreateProduct/{id}",
               new { action = "Create", Controller = "Product", id = UrlParameter.Optional }
           );
            context.MapRoute(
               "Admin_cetagory",
               "Admin/Category",
               new { action = "Index", Controller = "Category", id = UrlParameter.Optional }
           );
            context.MapRoute(
              "Admin_cetagory_edit",
              "Admin/EditCategory/{id}",
              new { action = "Edits", Controller = "Category", id = UrlParameter.Optional }
          );
          context.MapRoute(
              "Admin_cetagory_create",
              "Admin/CreateCategory/{id}",
              new { action = "Create", Controller = "Category", id = UrlParameter.Optional }
          );
            context.MapRoute(
               "Admin_Order",
               "Admin/Order/{id}",
               new { action = "Index", Controller = "Order", id = UrlParameter.Optional }
           );
            context.MapRoute(
               "Admin_DetailOrder",
               "Admin/DetailOrder/{id}",
               new { action = "Detail", Controller = "Order", id = UrlParameter.Optional }
           );
            context.MapRoute(
              "Admin_DetailOer",
              "Admin/Order/DetailOrder/{id}",
              new { action = "DetailOrder", Controller = "Order", id = UrlParameter.Optional }
          );
            context.MapRoute(
              "Admin_ajax",
              "HomeAdmin/Search/{type}",
              new { action = "Search", Controller = "HomeAdmin", type = UrlParameter.Optional }
          );
            context.MapRoute(
             "Admin_login",
             "Admin/Login",
             new { action = "Index", Controller = "Login", type = UrlParameter.Optional }
         );
            context.MapRoute(
             "Admin_loout",
             "Admin/Logout",
             new { action = "Logout", Controller = "Login", type = UrlParameter.Optional }
         );

        }
    }
}