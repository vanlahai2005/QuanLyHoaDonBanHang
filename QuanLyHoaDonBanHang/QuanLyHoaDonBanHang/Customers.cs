using System;
using System.Collections.Generic;

namespace QuanLyHoaDonBanHang
{
    public class Customer
    {
        private string name;
        private string phone;
        private List<Customer> customers = new List<Customer>();

        public Customer()
        {}
        public void AddCustomer()
        {
            Console.Write("Enter customer name: ");
            string name = Console.ReadLine();
            Console.Write("Enter customer phone: ");
            string phone = Console.ReadLine();

            customers.Add(new Customer());
            Console.WriteLine("Customer added successfully.");
        }
        public void ViewCustomerInfo()
        {
            Console.WriteLine("\nCustomer List:");
            if (customers.Count == 0)
            {
                Console.WriteLine("No customers found.");
                return;
            }

            foreach (var customer in customers)
            {
                Console.WriteLine($"Name: {customer.name}, Phone: {customer.phone}");
            }
        }
        public void SearchCustomerByPhone()
        {
            Console.Write("Enter customer phone to search: ");
            string phone = Console.ReadLine();

            var customer = customers.Find(c => c.phone == phone);
            if (customer != null)
            {
                Console.WriteLine($"Customer found: Name: {customer.name}, Phone: {customer.phone}");
            }
            else
            {
                Console.WriteLine("Customer not found.");
            }
        }
        public void RemoveCustomer()
        {
            Console.Write("Enter customer phone to remove: ");
            string phone = Console.ReadLine();

            var customer = customers.Find(c => c.phone == phone);
            if (customer != null)
            {
                customers.Remove(customer);
                Console.WriteLine("Customer removed successfully.");
            }
            else
            {
                Console.WriteLine("Customer not found.");
            }
        }
    }
}
