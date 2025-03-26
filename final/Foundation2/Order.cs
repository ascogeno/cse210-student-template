using System;

class Order
{
    private List<Product> products = new List<Product>();
    private Customer custom = new Customer();
    public Order()
    {

    }

    public int GetOrderTotal()
    {
        return 0;
    }

    public int GetShipping()
    {
        return 0;
    }

    public string GetPackingLabel()
    {
        return "";
    }

    public string GetShippingLabel()
    {
        return "";
    }
}