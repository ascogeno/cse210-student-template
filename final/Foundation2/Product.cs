using System;

class Product
{
    private string _pName;
    private int _pricePerUnit;
    private int _quantity;

    public Product(string name, int price, int quant)
    {
        _pName = name;
        _pricePerUnit = price;
        _quantity = quant;
    }

    public int GetTotal()
    {
        return 0;
    }
}