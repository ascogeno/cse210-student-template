using System;

class Customer
{
    private string _cName;
    private Address addy;

    public Customer(string name, string address)
    {
        _cName = name;
        addy = new Address(address);
    }

    public string GetName()
    {
        return _cName;
    }

    public bool IsUSA()
    {
        return addy.IsUSA();
    }

    public string GetFullDetails()
    {
        return addy.fullDetails();
    }
}