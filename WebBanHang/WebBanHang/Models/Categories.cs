using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebBanHang.Models
{
  

    public class Categories
    {
        ShopWallpaperEntities db;

        public Categories()
        {
            db = new ShopWallpaperEntities();
        }

        public IEnumerable<Category> GetAll()
        {
            return db.Categories.ToList();
        }

        public Category GetById(long id)
        {
            return db.Categories.Where(m => m.Id == id).SingleOrDefault();
        }

        public Category Insert(Category obj)
        {
            Category p= db.Categories.Add(obj);
             db.SaveChanges();
            return p;

        }

        public int Update(Category obj)
        {
            Category c = GetById(obj.Id);
            if(c!=null)
            {
                
                
                 
                db.Entry(c).CurrentValues.SetValues(obj);
               
            }
            return db.SaveChanges();

        }

        public int Delete(Category obj)
        {
            db.Categories.Remove(obj);
            return db.SaveChanges();

        }


    }
}