using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    internal class Product
    {
        public event Action<Product,int> OnSell;
        public string Name { get; set; }
        public float Price { get; set; }
        public int QuantityInStock { get; set; }

        public Product(string name, float price, int quantity)
        {
            Name = name ?? "";
            Price = price;
            QuantityInStock = quantity;
        }

        public void Sell(int quantity)
        {
            if(QuantityInStock > 0)
            {

                QuantityInStock -= quantity;

                OnSell?.Invoke(this,quantity);
            }
        }

        public override string ToString()
        {
            return $"{Name} - Price: {Price} - Stock: {QuantityInStock}";
        }
    }
}
