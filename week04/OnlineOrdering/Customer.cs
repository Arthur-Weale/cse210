



using System.Net.Sockets;

public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _address = address;
        _name = name;
    }

    public bool IsInUSA()
    {
        return _address.IsInUSA();;
    }

    public Address GetAddress()  
    {
        return _address;
    }
    public string GetName()
    {
        return _name; 
    }

}