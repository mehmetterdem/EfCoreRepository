using Northwind.DAL.Abstract;
using Northwind.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DAL.Concrete
{
    public class ShipperDal : IShipperDal
    {
        private NorthWindDbContext db;
        public int Add(Shipper shipper)
        {
           db.Shippers.Add(shipper);
            return db.SaveChanges();
        }

        public int Delete(Shipper shipper)
        {
            db.Remove(shipper);
            return db.SaveChanges();
        }

        public Shipper Get(int id)
        {
            return db.Shippers.Where(p=>p.ShipperId == id).FirstOrDefault();
        }

        public List<Shipper> GetAll()
        {
            return db.Shippers.ToList();
        }

        public int Update(Shipper shipper)
        {
            var result= db.Entry<Shipper>(shipper); 
            result.State=Microsoft.EntityFrameworkCore.EntityState.Modified;
            return  db.SaveChanges();
            
            
        }
    }
}
