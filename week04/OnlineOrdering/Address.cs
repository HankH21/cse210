public class Address
{
    private string _street;
    private string _city;
    private string _stateOrProvince;
    private string _country;

    public Address(string street, string city, string stateOrProvince, string country)
    {
        _street = street;
        _city = city;
        _stateOrProvince = stateOrProvince;
        _country = country;
    }

    public bool InUSA()
    {
        if (_country.ToUpper() == "USA")
        {
            return true;   
        }

        return false;
    }

    public string GetFullAddress()
    {
        string fullAddress = $"{_street}\n{_city}, {_stateOrProvince}\n{_country}";
        return fullAddress;
    }
}