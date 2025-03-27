using System;
using System.Runtime.InteropServices;

class Product
{
    private string _pName;
    private int _id;
    private int _pricePerUnit;
    private int _quantity;

    public Product(string name, int id, int price, int quant)
    {
        _pName = name;
        _id = id;
        _pricePerUnit = price;
        _quantity = quant;
    }

    public int GetId()
    {
        return _id;
    }

    public int GetTotal()
    {
        return _pricePerUnit * _quantity;
    }
}