using System;

class Program
{
    static void Main(string[] args)
    {
        // Step 1: Create Address
        Address address = new Address("123 Main St", "New York", "NY", "USA");

        // Step 2: Create Customer
        Customer customer = new Customer("John Doe", address);

        // Step 3: Create Products
        Product product1 = new Product("Laptop", 101, 1000.0f, 1);
        Product product2 = new Product("Mouse", 102, 50.0f, 2);

        // Step 4: Create Order
        Order order = new Order(customer);

        // Step 5: Add Products to Order
        order.AddProduct(product1);
        order.AddProduct(product2);

        // Step 6: Display Information
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order.GetShippingLabel());

        Console.WriteLine();
        Console.WriteLine(order.GetPackingLabel());

        Console.WriteLine($"\nTotal Cost: ${order.CalculateTotalCost()}");
    }
}