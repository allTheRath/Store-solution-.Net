using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using E_Comerce_DbFirst.ViewModels;

namespace E_Comerce_DbFirst.Models
{
    public class ProductsForCustomer
    {
        Entities2 db = new Entities2();
        public bool GetProducts()
        {
            db.Products.ToList();
            return true;
        }
    }
}