using System;

public class Program
{
    static void Main(string[] args)
    {
        List<Product> products = new List<Product>();
        Customer custLexi = new Customer("Lexi", new Address("123 South, 456 East", "Salt Lake City", "Utah", "USA"));
        Product p1 = new Product("Vacuum", 84335, 300, 1);
        Product p2 = new Product("Nail Polish", 49272, 6, 5);
        Product p3 = new Product("Granola Bars", 75892, 1, 50);

        Order orderLexi = new Order(custLexi, 0);
        orderLexi.AddProduct(p1);
        orderLexi.AddProduct(p2);
        orderLexi.AddProduct(p3);

        Console.WriteLine(orderLexi.PackingLabel());
        Console.WriteLine(orderLexi.ShippingLabel());
        Console.WriteLine("Your total is: " + orderLexi.CalculateTotal());

        Console.WriteLine();
        Console.WriteLine();



        Customer custXavier = new Customer("Xavier", new Address("789 North, 1011 West", "Rome", "Draucght BLV.", "Italy"));
        Product p4 = new Product("Sword", 10264, 500, 1);
        Product p5 = new Product("Wing Care", 78452, 25, 2);
        Product p6 = new Product("Wood Cleaner", 22346, 10, 1);

        Order orderXavier = new Order(custXavier, 0);
        orderXavier.AddProduct(p4);
        orderXavier.AddProduct(p5);
        orderXavier.AddProduct(p6);        

        Console.WriteLine(orderXavier.PackingLabel());
        Console.WriteLine(orderXavier.ShippingLabel());
        Console.WriteLine("Your total is: " + orderXavier.CalculateTotal());

        Console.WriteLine();
        Console.WriteLine();

        

        Customer custAlice = new Customer("Alice", new Address("1213 North, 1415 East", "St. Petersburg", "Province", "Russia"));
        Product p7 = new Product("Metal Polish", 74913, 35, 1);
        Product p8 = new Product("Paint", 99452, 3, 8);
        Product p9 = new Product("Canvas", 57992, 7, 3);

        Order orderAlice = new Order(custAlice, 0);
        orderAlice.AddProduct(p7);
        orderAlice.AddProduct(p8);
        orderAlice.AddProduct(p9);        

        Console.WriteLine(orderAlice.PackingLabel());
        Console.WriteLine(orderAlice.ShippingLabel());
        Console.WriteLine("Your total is: " + orderAlice.CalculateTotal());

    }
}