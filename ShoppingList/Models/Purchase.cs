using System;
using System.Collections.Generic;

namespace ShoppingList.Models
{
    public class Purchase
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public ICollection<Product> Products { get; set; } = new List<Product>();

        public Purchase()
        {
        }

        public Purchase(int id, DateTime date, double amount, Product d1)
        {
            Id = id;
            Date = date;
            Amount = amount;
        }

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }
        public void AddRemove(Product product)
        {
            Products.Remove(product);
        }
    }

}
