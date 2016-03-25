using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebBanHang.Models
{
    public class DetailOrderss
    {
        ShopWallpaperEntities db;

        public DetailOrderss()
        {
            db = new ShopWallpaperEntities();
        }

        public IEnumerable<DetailOrder> GetAll()
        {
            return db.DetailOrders.ToList();
        }

        public IEnumerable<DetailOrder> GetById(long id)
        {
            return db.DetailOrders.Where(m => m.Id == id).ToList();
        }

        public int Insert(DetailOrder obj)
        {
            db.DetailOrders.Add(obj);
            return db.SaveChanges();

        }

        public int Delete(DetailOrder obj)
        {
            db.DetailOrders.Remove(obj);
            return db.SaveChanges();

        }
        
    }
}