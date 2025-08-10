using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    internal class Store
    {
        public string Name { get; set; } = "";
        public float Revenue {  get; set; }
        List<Product> Products { get; set; } = new List<Product>();

        public Store(string name)
        {
            Name = name;
            Products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            Products.Add(product);

            product.OnSell += OnSellSendNews;

            product.OnSell += OnSellAdjustRevenue;
        }

        public void RemoveProduct(Product product)
        {
            Products.Remove(product);
        }

        public void OnSellAdjustRevenue(Product product,int qty)
        {
            Revenue += product.Price * qty;
        }
        public void OnSellSendNews(Product product,int qty)
        {
            Console.WriteLine($"{product.Name}:sold with {qty}");
        }

        public List<Product> FilterProducts(Func<Product, bool> filter)
        {
            return Products.Where(filter).ToList();
        }
        public override string ToString()
        {
            return $"{Name} - Revenue: {Revenue}";
        }
    }
}
