using System;

namespace ProductOrderingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Address address1 = new Address("123 Main St", "Springfield", "IL", "USA");
            Address address2 = new Address("456 Elm St", "Toronto", "ON", "Canada");

            Customer customer1 = new Customer("John Doe", address1);
            Customer customer2 = new Customer("Jane Smith", address2);

            Product product1 = new Product("Widget", "W123", 10.50m, 2);
            Product product2 = new Product("Gadget", "G456", 15.75m, 1);
            Product product3 = new Product("Doohickey", "D789", 7.99m, 3);

            Order order1 = new Order(customer1);
            order1.AddProduct(product1);
            order1.AddProduct(product2);

            Order order2 = new Order(customer2);
            order2.AddProduct(product2);
            order2.AddProduct(product3);

            Console.WriteLine(order1.GetPackingLabel());
            Console.WriteLine(order1.GetShippingLabel());
            Console.WriteLine($"Total Price: ${order1.GetTotalPrice():0.00}");
            Console.WriteLine(new string('-', 40));

            Console.WriteLine(order2.GetPackingLabel());
            Console.WriteLine(order2.GetShippingLabel());
            Console.WriteLine($"Total Price: ${order2.GetTotalPrice():0.00}");
        }
    }
}
