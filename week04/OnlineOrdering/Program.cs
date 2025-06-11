using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 E 456 S", "Salt Lake City", "UT", "USA");
        Address address2 = new Address("221B Baker Street", "London", "Greater London", "United Kingdom");

        Customer customer1 = new Customer("Ken Gushi", address1);
        Customer customer2 = new Customer("James Deane", address2);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Smartphone Case", "A031", 25.75, 2));
        order1.AddProduct(new Product("Smartphone Tempered Glass", "A059", 12.99, 1));

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("SEIKO Sport Watch", "C305", 265, 1));
        order2.AddProduct(new Product("Watch Tool Set", "C488", 105.99, 1));

        Console.WriteLine("Packing Label:\n" + order1.GetPackingLabel());
        Console.WriteLine("Shipping Label:\n" + order1.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost()}");
        Console.WriteLine();

        Console.WriteLine("Packing Label:\n" + order2.GetPackingLabel());
        Console.WriteLine("Shipping Label:\n" + order2.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost()}");
        Console.WriteLine();
               
    }

}