class Address
{
    private string _address;
    public Address(string address)
    {
        _address = address;
    }

    public string GetAddresss()
    {
        return $"{_address}";
    }
}