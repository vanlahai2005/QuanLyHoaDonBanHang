using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHoaDonBanHang
{
    public class Store
    {
        private List<Item> products = new List<Item>();
        public Store() { }

        public void AddProduct(Item product)
        {
            products.Add(product);
            Console.WriteLine("Product added successfully.");
        }
        public void SaleProduct()
        {
            Console.Write("Enter product ID: ");
            string id = Console.ReadLine();
            Console.Write("Enter product name: ");
            string name = Console.ReadLine();
            Console.Write("Enter price: ");
            double price = double.Parse(Console.ReadLine());
            Console.Write("Enter stock: ");
            int stock = int.Parse(Console.ReadLine());
            Item saleProduct = new Item(id, name, price, stock);
            products.Remove(saleProduct);
            Console.WriteLine("Sale sucessfully!");

        }


        public void DisplayAllProducts()
        {
            if (products.Count == 0)
            {
                Console.WriteLine("No products available.");
                return;
            }

            Console.WriteLine("Product List:");
            foreach (var product in products)
            {
                product.DisplayInfo();
            }
        }

        public Item SearchProductById(string id)
        {
            return products.FirstOrDefault(p => p.Id == id);
        }

        public List<Item> GetAllProducts() => products;
    }

    //tien ich: tinh tien thue, giam gia
    
}
