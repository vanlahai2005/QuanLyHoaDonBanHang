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

        public void AddItem(Item product, int quantity)
        {
            if (product.Stock < quantity)
            {
                Console.WriteLine("Not enough stock!");
                return;
            }
            items.Add(new InvoiceItem(product, quantity));
            product.UpdateStock(-quantity); //giam so luong hang ton kho
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
