using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebBanHang.Models
{
    public class Orderss
    {
        ShopWallpaperEntities db;

        public Orderss()
        {
            db = new ShopWallpaperEntities();
        }

        public IEnumerable<Order> GetAll()
        {
            return db.Orders.ToList();
        }

        public Order GetById(long id)
        {
            return db.Orders.Where(m => m.Id == id).SingleOrDefault();
        }

        public int Insert(Order obj)
        {
            db.Orders.Add(obj);
            return db.SaveChanges();

        }

        public int Delete(Order obj)
        {
            db.Orders.Remove(obj);
            return db.SaveChanges();

        }
        public void Update(Order obj)
        {
            Order  pro = GetById(obj.Id);
            db.Entry(pro).CurrentValues.SetValues(obj);
            db.SaveChanges();
        }

    }
}