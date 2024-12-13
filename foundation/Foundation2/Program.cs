using System;

class Program
{
    static void Main(string[] args)
    {
        // Create Address objects
        Address address1 = new Address("123 Maple Street", "Springfield", "IL", "USA");
        Address address2 = new Address("456 Oak Avenue", "Toronto", "ON", "Canada");

        // Create Customer objects
        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);

        // Create Product objects
        Product product1 = new Product("Widget A", "A123", 10.99m, 2);
        Product product2 = new Product("Gadget B", "B456", 5.99m, 3);
        Product product3 = new Product("Thingamajig C", "C789", 2.49m, 5);

        // Create Order objects
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);

        // Display details for each order
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost():F2}\n");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost():F2}");
    }
}
