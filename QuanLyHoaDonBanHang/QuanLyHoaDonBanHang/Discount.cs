using System;

namespace QuanLyHoaDonBanHang
{
    public class Discount
    {
        public static void ApplyDiscount(Invoice invoice)
        {
            if (invoice == null)
            {
                Console.WriteLine("Invoice is null!");
                return;
            }

            Console.Write("Enter discount percentage: ");
            if (!double.TryParse(Console.ReadLine(), out double discount) || discount < 0 || discount > 100)
            {
                Console.WriteLine("Invalid discount percentage! Must be between 0 and 100.");
                return;
            }

            double totalBeforeDiscount = invoice.GetTotalAmount();
            double discountAmount = totalBeforeDiscount * (discount / 100);
            double totalAfterDiscount = totalBeforeDiscount - discountAmount;

            Console.WriteLine($"\nDiscount Applied: {discount}%");
            Console.WriteLine($"Total Before Discount: {totalBeforeDiscount:C}");
            Console.WriteLine($"Discount Amount: {discountAmount:C}");
            Console.WriteLine($"Total After Discount: {totalAfterDiscount:C}");
        }
    }
}
