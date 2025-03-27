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
        ParseAddress(_fullAddress);
    }

    private void ParseAddress(string fullAddress)
    {
        var parts = fullAddress.Split(',').Select(p => p.Trim()).ToList(); //ha, had chatGPT make this bit. way more elegant than what I was planning
        int streetIndex = parts.FindIndex(p => char.IsDigit(p[0])); //this too, I'm only so good at lambda functions

        if (streetIndex == -1 || streetIndex + 2 >= parts.Count)
        {
            throw new ArgumentException("Invalid address format"); //suggestion from chat, which I'm keeping. the idea was to add code that checks the addresses so that variables
                                                                   //can be assigned properly, so I'm alright with this. 
        }
        _streetAddress = parts[streetIndex];
        _city = parts[streetIndex + 1];
        _stateOrProvince = parts[streetIndex + 2];

        _country = IsUSA() ? "USA" : "Not the US, that's the for sure"; //never seen this syntax before, but I get the idea. It's very neat
    }

    public bool IsUSA()
    {
        string[] usStates = { "AL", "AK", "AZ", "AR", "CA", "CO", "CT", "DE", "FL", "GA",
                              "HI", "ID", "IL", "IN", "IA", "KS", "KY", "LA", "ME", "MD",
                              "MA", "MI", "MN", "MS", "MO", "MT", "NE", "NV", "NH", "NJ",
                              "NM", "NY", "NC", "ND", "OH", "OK", "OR", "PA", "RI", "SC",
                              "SD", "TN", "TX", "UT", "VT", "VA", "WA", "WV", "WI", "WY"};

        return usStates.Contains(_stateOrProvince); //never used Contaions before, but this is also more elegant thant the for loop I had in mind
    }

    public string fullDetails()
    {
        return $"{_streetAddress}, {_city},\n{_stateOrProvince}, {_country}";
    }
}