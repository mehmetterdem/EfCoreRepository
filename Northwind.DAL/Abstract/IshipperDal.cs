﻿using Northwind.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DAL.Abstract
{
    public interface IShipperDal
    {
        int Add(Shipper shipper);

        int Update(Shipper shipper);
        int Delete(Shipper shipper);
        Shipper Get(int id);
        List<Shipper> GetAll();
        
    }
}
