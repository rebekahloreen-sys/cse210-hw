using System.Reflection;

public class Customer
{
    private string _customerName;
    private Address _address;

    public Customer(string customerName, Address address)
    {
        _customerName = customerName;
        _address = address;
    }
    Address addr = new Address();
    public bool InUSA()
    {
        return _address.InUSA();
    }
    public string ShippingLabel()
    {
        return _customerName + ", " + _address.FullAddress();
    }
}