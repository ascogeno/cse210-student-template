using System;
using System.Numerics;

class Order
{
    private List<Product> products = new List<Product>();
    private Customer custom;
    public Order(string name, string address)
    {
        custom = new Customer(name, address);
    }

    public void AddProduct(string name, int id, int price, int quant)
    {
        products.Add(new Product(name, id, price, quant));
    }

    public int GetOrderTotal()
    {
        if (products.Count == 0)
        {
            return 0;
        }
        else
        {
            int total = 0;
            foreach (Product prod in products)
            {
                total += prod.GetTotal();
            }
            return total + GetShipping();
        }

    }

    public int GetShipping()
    {
        if (custom.IsUSA())
        {
            return 5;
        }
        else
        {
            return 35;
        }
    }

    public void GetPackingLabel()
    {
        Console.WriteLine($"Packing Label for: {custom.GetName()}");
        Console.WriteLine("Product IDs: ");
        foreach (Product prod in products)
        {
            Console.Write($"{prod.GetId()} ");
        }
        Console.WriteLine("");
    }

    public void GetShippingLabel()
    {
        Console.WriteLine($"Shipping Label for: {custom.GetName()}, {custom.GetFullDetails()}");
    }
}