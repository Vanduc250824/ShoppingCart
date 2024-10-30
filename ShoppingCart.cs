using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    public class ShoppingCart
    {
        private List<Product> products = new List<Product>();
        public void AddProduct(Product product) { 
            products.Add(product);
        }
        public void RemoveProduct(Product product) {
            products.Remove(product);
        }
        public decimal CaculateTotal() {
            decimal total = 0;
            foreach (var product in products)
            {
                total += product.getPrice() * product.getQuantity();
            }
            return total;
        }
        public void ClearProduct(Product product) {
            products.Clear();
        }
        public List<Product> GetProducts() { return products; }
    }
}
