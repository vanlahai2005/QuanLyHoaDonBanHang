using System;
using System.Collections.Generic;

namespace QuanLyHoaDonBanHang
{
    class Saler
    {
        private bool exit = false;
        private Store hanghoa = new Store();
        private Invoice hoadon = new Invoice();
        private Customer customermanager = new Customer();

        public void QuanLyNhanVien()
        {
            while (!exit)
            {
                Console.WriteLine("\nSales Invoice Management:");
                Console.WriteLine("0. Sale Products");
                Console.WriteLine("1. Display All Products");
                Console.WriteLine("2. Add Item to Invoice");
                Console.WriteLine("3. Display Invoice");
                Console.WriteLine("4. Add Customer");
                Console.WriteLine("5. View Customer Information");
                Console.WriteLine("6. Apply Discount");
                Console.WriteLine("7. Exit");
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "0":
                        hanghoa.SaleProduct();
                        break;

                    case "1":
                        hanghoa.DisplayAllProducts();
                        break;

                    case "2":
                        hoadon.AddItemToInvoice(hanghoa);
                        break;

                    case "3":
                        hoadon.DisplayInvoice();
                        break;

                    case "4":
                        customermanager.AddCustomer();
                        break;

                    case "5":
                        customermanager.ViewCustomerInfo();
                        break;

                    case "6":
                        Discount.ApplyDiscount(hoadon);
                        break;

                    case "7":
                        exit = true;
                        Console.WriteLine("Exiting...");
                        break;

                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        break;
                }
            }
        }
    }
}
