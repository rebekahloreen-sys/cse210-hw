public class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateOrProvince;
    private string _country;

    public string FullAddress()
    {
        return _streetAddress + ", " + _city + ", " + _stateOrProvince + ", " + _country;
    }

    public Address(string streetAddress, string city, string stateOrProvince, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _stateOrProvince = stateOrProvince;
        _country = country;
    }
    public Address()
    {
        _streetAddress = "";
        _city = "";
        _stateOrProvince = "";
        _country = "";
    }
    public bool InUSA()
    {
        if (string.IsNullOrWhiteSpace(_country)) return false;
        string country = _country.Trim();
        return country == "USA";      
    }

}