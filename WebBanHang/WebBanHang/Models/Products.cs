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
            //db.Configuration.ProxyCreationEnabled = false;
        }

        public IEnumerable<Product> GetAll()
        {
            IEnumerable < Product > result= db.Products.ToList();
            
            return result;

        }

        //public IEnumerable<Product> GetBySearchKeyWord(string value)
        //{
        //    IEnumerable<Product> result = db.Products.Contains( value);

        //    return result;

        //}

        public  Product GetById(long id)
        {
            return db.Products.Where(m => m.Id == id).SingleOrDefault();
        }

        public Product Insert( Product obj)
        {
            Product p= db.Products.Add(obj);
              db.SaveChanges();
            return p;
        }

        public int Delete( Product obj)
        {
            db.Products.Remove(obj);
            return db.SaveChanges();

        }
        public void Update(Product obj)
        {
            Product pro = GetById(obj.Id);
            db.Entry(pro).CurrentValues.SetValues(obj);
            db.SaveChanges();
        }



    }
}