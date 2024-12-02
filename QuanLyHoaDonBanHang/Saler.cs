using System;
using System.Collections.Generic;

namespace QuanLyHoaDonBanHang
{
    //t?o class c?a ng??i b�n 
    class Saler
    {
        private bool exit = false;
        private Store hanghoa = new Store();
        private Invoice hoadon = new Invoice();
        private Customer customermanager = new Customer();

        //t?o h�m c�c ch?c n?ng c?a nh�n vi�n, c� copy l?i ph?n program v� th�m m?t s? ch?c n?ng nh? b�n, th�m t�m kh�ch h�ng, xem th�ng tin kh�ch h�ng v� khuy?n m�i
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
                        hoadon.AddItemToInvoice(hanghoa);//h�m n�y d�ng ?? th�m m?t h�ng h�a c? th? nh?p t? ng??i b�n v�o h�a ??n
                        break;

                    case "3":
                        hoadon.DisplayInvoice();
                        break;

                    case "4":
                        customermanager.AddCustomer();//H�m th�m th�ng tin kh�ch h�ng v�o shop, gi?ng nh? l?u th�ng tin ?? li�n l?c hay th�ng b�o khi c� s?n ph?m m?i,..
                        break;

                    case "5":
                        customermanager.ViewCustomerInfo();//Xem to�n b? th�ng tin kh�ch h�ng
                        break;

                    case "6":
                        Discount.ApplyDiscount(hoadon);//n�y em d�ng h�m static ?? d? s? d?ng cho c�c h�ng kh�c khi c?n d�ng ??n
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
