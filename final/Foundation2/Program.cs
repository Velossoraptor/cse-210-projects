using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("1234 Facet Street", "West Jordan", "Utah", "USA");
        Customer customer1 = new Customer("Nathan Maynes", address1);
        Product pro1 = new Product("Sweater", "SW-01", 35.55, 2);
        Product pro2 = new Product("Shoes", "SH-47", 107.35, 1);
        Product pro3 = new Product("Scarf", "SC-15", 12.50, 1);
        Order ord1 = new Order(customer1);
        ord1.AddProduct(pro1);
        ord1.AddProduct(pro2);
        ord1.AddProduct(pro3);

        Console.WriteLine($"Order:\n{ord1.GetPackingLabel()}{ord1.GetShippingLabel()}");
        Console.WriteLine($"Price: {ord1.GetTotalPrice()}");
        Console.WriteLine("\n\n");

        Address address2 = new Address("1234 Underway", "Kingston", "Ontario", "CA");
        Customer customer2 = new Customer("Nicholas Strong", address2);
        Product pro4 = new Product("Assorted Candy", "CA-24", 5.50, 2);
        Product pro5 = new Product("Necklace", "JN-70", 10.00, 1);
        Product pro6 = new Product("Stuffed Dragon", "SD-05", 12.50, 1);
        Order ord2 = new Order(customer2);
        ord2.AddProduct(pro4);
        ord2.AddProduct(pro5);
        ord2.AddProduct(pro6);

        Console.WriteLine($"Order:\n{ord2.GetPackingLabel()}{ord2.GetShippingLabel()}");
        Console.WriteLine($"Price: {ord2.GetTotalPrice()}");
        Console.WriteLine("\n\n");
    }
}