using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_Comerce_DbFirst.ViewModels
{
    public class ViewInitilizer
    {
        public ProductDisplay Product { get; set; }
        public List<ProductDisplay> Products { get; set; }
        public OrderDisplay Order { get; set; }
        public List<OrderDisplay> Orders { get; set; }
        public ViewInitilizer()
        {
            this.Product = new ProductDisplay();
            this.Products = new List<ProductDisplay>();
            this.Order = new OrderDisplay();
            this.Orders = new List<OrderDisplay>();
        }
    }

    public class OrderDisplay
    {
        public int id { get; set; }
        public int Quantity { get; set; }
        public System.DateTime ExpectedDilivary { get; set; }
        public string OrderStatus { get; set; }
        public float OrderTotal { get; set; }
        public int CartId { get; set; }
        public int CustomerId { get; set; }

    }

  

    public class ProductDisplay
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Discription { get; set; }
        public string ImageUrl { get; set; }
        public int Quantity { get; set; }
        public float Price { get; set; }
    }

  


}