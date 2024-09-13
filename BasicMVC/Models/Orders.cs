﻿namespace BasicMVC.Models
{
    public class Orders
    {

        public int Id { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public Orders(int id, string productName, decimal price, int quantity)
        {
            Id = id;
            ProductName = productName;
            Price = price;
            Quantity = quantity;
        }
    }
}
