using System;

class Program
{
    static void Main(string[] args)
    {
        // Order 1: USA Customer
        Address address1 = new Address("123 Main St", "Rexburg", "ID", "USA");
        Customer customer1 = new Customer("John Doe", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Wireless Mouse", "P101", 25.99, 2));
        order1.AddProduct(new Product("Mechanical Keyboard", "P102", 75.50, 1));

        // Order 2: International Customer
        Address address2 = new Address("45 Innovation Way", "Enugu", "Enugu State", "Nigeria");
        Customer customer2 = new Customer("Adaobi Okafor", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("USB-C Hub", "P201", 18.00, 3));
        order2.AddProduct(new Product("Monitor Stand", "P202", 42.00, 1));

        // Display Order 1 Details
        Console.WriteLine("=================================");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.CalculateTotalCost():F2}\n");

        // Display Order 2 Details
        Console.WriteLine("=================================");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.CalculateTotalCost():F2}\n");
    }
}