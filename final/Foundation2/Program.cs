using System;

class Program
{
    static Order order1 = new Order("Steve", "490 N 2nd E, Rexburg, ID");
    static Order order2 = new Order("Devon", "Empress Tea Lobby, 721 Government St, Victoria, BC");
    static void Main(string[] args)
    {
        order1.AddProduct("Laptop", 1, 2000, 1);
        order1.AddProduct("Apple", 35, 2, 15);
        order2.AddProduct("Laptop", 1, 2000, 2);
        order2.AddProduct("Extension Cord", 175, 10, 3);
        DisplayOrder(order1);
        DisplayOrder(order2);
    }

    public static void DisplayOrder(Order ord)
    {
        ord.GetPackingLabel();
        ord.GetShippingLabel();
        Console.WriteLine($"Order Total: {ord.GetOrderTotal()}\n\n");
    }
}