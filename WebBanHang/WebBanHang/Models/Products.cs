using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebBanHang.Models
{
    

    public class Products
    {
        ShopWallpaperEntities db;

        public Products()
        {
            db = new ShopWallpaperEntities();
        }

        public IEnumerable<Product> GetAll()
        {
            return db.Products.ToList();
        }

        public  Product GetById(long id)
        {
            return db.Products.Where(m => m.Id == id).SingleOrDefault();
        }

        public int Insert( Product obj)
        {
            db.Products.Add(obj);
            return db.SaveChanges();

        }

        public int Delete( Product obj)
        {
            db.Products.Remove(obj);
            return db.SaveChanges();

        }


    }
}