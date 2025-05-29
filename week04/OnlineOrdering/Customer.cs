using System;

public class Customer
{
    private string customerName;
    private Address address;

    public Customer(string name, Address address)
    {
        this.customerName = name;
        this.address = address;
    }

    public bool IsInUS()
    {
        return address.IsInUS();
    }

    public string GetName()
    {
        return customerName;
    }

    public string GetShippingAddress()
    {
        return address.GetFullAddress();
    }
}