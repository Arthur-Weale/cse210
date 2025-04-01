using System;

// Program.cs
class Program
{
    static void Main(string[] args)
    {
        // ---- Order 1 ----
        // Create Address, Customer, and Products for Order 1
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Customer customer1 = new Customer("John Doe", address1);
        Order order1 = new Order(customer1);

        Product product1 = new Product("Laptop", 101, 1000, 1);
        Product product2 = new Product("Mouse", 102, 50, 2);

        order1.AddProduct(product1);
        order1.AddProduct(product2);

        // ---- Order 2 ----
        // Create Address, Customer, and Products for Order 2
        Address address2 = new Address("456 Elm St", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Jane Smith", address2);
        Order order2 = new Order(customer2);

        Product product3 = new Product("Smartphone", 201, 800, 1);
        Product product4 = new Product("Headphones", 202, 150, 1);

        order2.AddProduct(product3);
        order2.AddProduct(product4);

        // ---- Display Order Information ----
        Console.WriteLine("Order 1:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost()}\n");

        Console.WriteLine("Order 2:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost()}\n");
    }
}