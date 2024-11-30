using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHoaDonBanHang
{
    public class InvoiceItem
    {
        private Item product;
        private int quantity;

        public InvoiceItem(Item product, int quantity)
        {
            this.product = product;
            this.quantity = quantity;
        }
        public double GetTotalPrice()
        {
            return product.Price * quantity;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Product: {product.Name}, Quantity: {quantity}, Total: {GetTotalPrice():C}");
        }
    }
}
