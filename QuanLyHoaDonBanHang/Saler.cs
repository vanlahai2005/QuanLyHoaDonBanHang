using System;
using System.Collections.Generic;

namespace QuanLyHoaDonBanHang
{
    //t?o class c?a ng??i bán 
    class Saler
    {
        private bool exit = false;
        private Store hanghoa = new Store();
        private Invoice hoadon = new Invoice();
        private Customer customermanager = new Customer();

        //t?o hàm các ch?c n?ng c?a nhân viên, có copy l?i ph?n program và thêm m?t s? ch?c n?ng nh? bán, thêm têm khách hàng, xem thông tin khách hàng và khuy?n mãi
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
                        hoadon.AddItemToInvoice(hanghoa);//hàm này dùng ?? thêm m?t hàng hóa c? th? nh?p t? ng??i bán vào hóa ??n
                        break;

                    case "3":
                        hoadon.DisplayInvoice();
                        break;

                    case "4":
                        customermanager.AddCustomer();//Hàm thêm thông tin khách hàng vào shop, gi?ng nh? l?u thông tin ?? liên l?c hay thông báo khi có s?n ph?m m?i,..
                        break;

                    case "5":
                        customermanager.ViewCustomerInfo();//Xem toàn b? thông tin khách hàng
                        break;

                    case "6":
                        Discount.ApplyDiscount(hoadon);//này em dùng hàm static ?? d? s? d?ng cho các hàng khác khi c?n dùng ??n
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
