using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShoppingList.Models;
using ShoppingList.Data;

namespace ShoppingList.Data
{
    public class SeedingService
    {
        private ShoppingListContext _context;
        public SeedingService(ShoppingListContext context)
        {
            _context = context;
        }
        public void Seed()
        {
            if (_context.Product.Any() ||
                _context.Purchase.Any())
            {
                return; // DB has been seeded
            }

            Product d1 = new Product(1, "Macarão", 2, 8.30, 17.0, 1);
            Product d2 = new Product(2, "Arroz", 2, 22.00, 44.0, 1);

            Product d3 = new Product { Id = 3, Name = "Café", Quantity = 2, Price = 5.0, AmountProduct = 10.0, PurchaseId = 2 };

            Purchase s1 = new Purchase(1, new DateTime(2021, 1, 21), 17.0, d1);

            _context.Product.AddRange(d1, d2);
            _context.Purchase.AddRange(s1);

            _context.SaveChanges();
        }


    }
}
