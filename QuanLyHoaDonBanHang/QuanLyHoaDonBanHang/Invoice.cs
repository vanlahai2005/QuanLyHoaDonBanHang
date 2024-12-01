using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHoaDonBanHang
{
    public class Invoice
    {
        private List<InvoiceItem> items = new List<InvoiceItem>();

        public void AddItemToInvoice(Store store)
        {
            Console.Write("Enter product ID: ");
            string productid = Console.ReadLine();

            if (string.IsNullOrEmpty(productid))
            {
                Console.WriteLine("Invalid product ID!");
                return;
            }

            Item product = store.SearchProductById(productid);
            if (product == null)
            {
                Console.WriteLine("Product not found!");
                return;
            }

            Console.Write("Enter quantity: ");
            if (!int.TryParse(Console.ReadLine(), out int quantity) || quantity <= 0)
            {
                Console.WriteLine("Invalid quantity!");
                return;
            }

            if (product.Stock < quantity)
            {
                Console.WriteLine("Not enough stock!");
                return;
            }

            // Add the product to the invoice and reduce stock
            items.Add(new InvoiceItem(product, quantity));
            product.UpdateStock(-quantity);
            Console.WriteLine("Item added to invoice.");
        }


        public void DisplayInvoice()
        {
            if (items.Count == 0)
            {
                Console.WriteLine("Invoice is empty.");
                return;
            }

            Console.WriteLine("Invoice Details:");
            foreach (var item in items)
            {
                item.DisplayInfo();
            }
            Console.WriteLine($"Total Amount (with Tax): {GetTotalAmountWithTax():C}");
        }
        public double GetTotalAmount()
        {
            double total = 0;
            foreach (var item in items)
            {
                total += item.GetTotalPrice();
            }
            return total;
        }
        public double GetTotalAmountWithTax()
        {
            double tax = Utilities.CalculateTax(GetTotalAmount());
            return GetTotalAmount() + tax;
        }
    }
}
