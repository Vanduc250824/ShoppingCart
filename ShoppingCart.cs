using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    public class ShoppingCart
    {
        public List<Product> Items { get; private set; } = new List<Product>();

        public void AddProduct(Product product)
        {
            var existingProduct = Items.FirstOrDefault(p => p.Name == product.Name);
            if (existingProduct != null)
            {
                existingProduct.Quantity += product.Quantity; // Cập nhật số lượng
            }
            else
            {
                Items.Add(new Product(product.Image, product.Name, product.Price, product.Quantity)); 
            }
        }

        public void RemoveProduct(Product product)
        {
            Items.RemoveAll(p => p.Name == product.Name);
        }

        public double CalculateTotal() 
        {
            return Items.Sum(p => p.Price * p.Quantity); 
        }

        public void Clear()
        {
            Items.Clear();
        }
    }
}

