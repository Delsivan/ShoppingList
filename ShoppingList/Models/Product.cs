using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingList.Models
{
    public class Product
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public double AmountProduct { get; set; }
        public int PurchaseId { get; set; }
        public Purchase Purchase { get; set; }

        public Product()
        {
        }

        public Product(int id, string name, int quantity, double price, double amountProduct, int purchaseId)
        {
            Id = id;
            Name = name;
            Quantity = quantity;
            Price = price;
            AmountProduct = amountProduct;
            PurchaseId = purchaseId;
        }

    }


}
