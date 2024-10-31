﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public Image Image { get; set; }


        public Product(Image image, string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
            Image = image;
        }
        
    }
}
