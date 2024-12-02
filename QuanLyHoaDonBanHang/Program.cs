
namespace QuanLyHoaDonBanHang
{
    class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store();
            Invoice invoice = new Invoice();
            bool exit = false;
            Saler nhanvien = new Saler();

            store.AddProduct(new Item("P001", "Laptop", 1500, 10));
            store.AddProduct(new Item("P002", "Mouse", 25, 50));
            store.AddProduct(new Item("P003", "Keyboard", 45, 30));

            nhanvien.QuanLyNhanVien();

            while (!exit)
            {
                Console.WriteLine("\nSales Invoice Management");
                Console.WriteLine("1. Add Product to Store");
                Console.WriteLine("2. Display All Products");
                Console.WriteLine("3. Add Item to Invoice");
                Console.WriteLine("4. Display Invoice");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter product ID: ");
                        string id = Console.ReadLine();
                        Console.Write("Enter product name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter price: ");
                        double price = double.Parse(Console.ReadLine());
                        Console.Write("Enter stock: ");
                        int stock = int.Parse(Console.ReadLine());
                        store.AddProduct(new Item(id, name, price, stock));
                        break;

                    case "2":
                        store.DisplayAllProducts();
                        break;
                    case "4":
                        invoice.DisplayInvoice();
                        break;

                    case "5":
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
