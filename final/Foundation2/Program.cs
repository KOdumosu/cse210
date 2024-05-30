using System;

class Program
{
    static void Main(string[] args)
    {

        Address address1 = new Address("456 Oak Ave", "Smallville", "NY 54321", "USA");
        Address address2 = new Address("789 Plaza del Sol", "Mexico", "City", "Mexico");

        Customer customer1 = new Customer("Alice Johnson", address1);
        Customer customer2 = new Customer("Diego Rodriguez", address2);

        Order order1 = new Order(customer1);
        Product product1 = new Product("Laptop Stand", "LS123", (decimal)29.99, 2);
        Product product2 = new Product("Bluetooth Earbuds", "BE456", (decimal)39.99, 1);
        Product product3 = new Product("Portable Charger", "PC789", (decimal)19.99, 3);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);
        
        Order order2 = new Order(customer2);
        Product product4 = new Product("Smart Watch", "SW789", (decimal)79.99, 1);
        Product product5 = new Product("Camera Backpack", "CB456", (decimal)49.99, 2);
        Product product6 = new Product("Noise-Canceling Headphones", "NH123", (decimal)89.99, 1);
        order2.AddProduct(product4);
        order2.AddProduct(product5);
        order2.AddProduct(product6);

        Console.WriteLine("Order 1 Packing Label:\n");
        Console.WriteLine(order1.GetPackingLabel());

        Console.WriteLine("Order 1 Shipping Label:\n");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice()}");
        Console.WriteLine();

        Console.WriteLine("Order 2 Packing Label:\n");
        Console.WriteLine(order2.GetPackingLabel());

        Console.WriteLine("Order 2 Shipping Label:\n");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice()}");
        Console.WriteLine();


    }
}