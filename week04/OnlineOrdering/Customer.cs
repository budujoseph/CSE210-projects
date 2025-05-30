using System;

public class Customer
{
    private string _customerName;
    private Address _address;

    public Customer(string name, Address address)
    {
        this._customerName = name;
        this._address = address;
    }

    public bool IsInUS()
    {
        return _address.IsInUS();
    }

    public string GetName()
    {
        return _customerName;
    }

    public string GetShippingAddress()
    {
        return _address.GetFullAddress();
    }
}