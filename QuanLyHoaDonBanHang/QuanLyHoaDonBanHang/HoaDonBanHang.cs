using System;
using System.Collections.Generic;
using System.Linq;

namespace QuanLyHoaDonBanHang
{
    public class Item
    {
        private string id;
        private string name;
        private double price;
        private int stock;
        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public Item(string id, string name, double price, int stock)
        {
            Id = id;
            Name = name;
            Price = price;
            Stock = stock;
        }



        public void UpdateStock(int quantity)
        {
            Stock += quantity;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"ID: {Id}, Name: {Name}, Price: {Price:C}, Stock: {Stock}");
        }

        public double CalculateDiscount()
        {
            return Price > 100 ? Price * 0.05 : 0; // giam gia 5% neu gia >100
        }
    }
    //}
}
