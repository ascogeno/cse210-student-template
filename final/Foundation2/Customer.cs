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

    public bool IsUSA()
    {
        return false;
    }
}