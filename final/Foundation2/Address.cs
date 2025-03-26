using System;
using System.Runtime.CompilerServices;

class Address
{
    private string _fullAddress;
    private string _streetAddress;
    private string _city;
    private string _stateOrProvince;
    private string _country;
    public Address(string address)
    {
        _fullAddress = address;
    }

    private void ParseAddress(string fullAddress)
    {

    }

    public bool IsUSA()
    {
        return false;
    }

    public string fullDetails()
    {
        return "";
    }
}