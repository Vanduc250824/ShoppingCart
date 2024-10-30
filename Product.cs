using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    public class Product
    {
        private String Name { get; set; }
        private decimal Price { get; set; }
        private int Quantity { get; set; }
        private Image image { get; set; }

        public Product(String _Name, decimal _Price, int _Quantity, Image _image) {
            this.Name = _Name;
            this.Price = _Price;
            this.Quantity = _Quantity;
            this.image = _image;
        }
        public decimal getPrice()
        {
            return Price;
        }
        public int getQuantity() { return Quantity; }
    }
}
