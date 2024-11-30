using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHoaDonBanHang
{
    public static class Utilities
    {
        public static double CalculateTax(double amount, double taxRate = 0.1)
        {
            return amount * taxRate;
        }

        public static double ApplyDiscount(double amount, double discountRate)
        {
            return amount - (amount * discountRate);
        }
    }

    //ham ti le thue, don vi tien te
    public static class Config
    {
        public static string CurrencySymbol = "VND";  // don vi tien te
        public static double TaxRate = 0.1;  // thue mac dinh

        public static void DisplayConfig()
        {
            Console.WriteLine($"Currency Symbol: {CurrencySymbol}");
            Console.WriteLine($"Tax Rate: {TaxRate * 100}%");
        }
    }
    public static class ReportManager
    {
        public static void GenerateTopSellingProductsReport(Store store)
        {
            Console.WriteLine("Top Selling Products:");
            foreach (var product in store.GetAllProducts().OrderByDescending(p => p.Price))
            {
                Console.WriteLine($"Product: {product.Name}, Price: {product.Price:C}");
            }
        }
    }
}
