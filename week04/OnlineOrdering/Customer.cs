using System.Net.Sockets;

public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool AddressValidator()
    {
        return _address.AddressValidator();
    }
    public string GetDisplayShippingLabel()
    {
        return $"{_name}\n{_address.GetDisplayAddress()}";
    }
}