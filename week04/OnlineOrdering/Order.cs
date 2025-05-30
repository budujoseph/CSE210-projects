using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        this._products = new List<Product>();
        this._customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double GetTotalCost()
    {
        double totalCost = 0;
        foreach (var product in _products)
        {
            totalCost += product.GetTotalCost();
        }

        totalCost += _customer.IsInUS() ? 5 : 35;
        return totalCost;
    }

    public string PackageLabel()
    {
        string label = "Packing Label: \n";
        foreach (var product in _products)
        {
            label += product.GetProductInfo() + "\n";
        }

        return label;
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label: \n{_customer.GetName()}\n{_customer.GetShippingAddress()}";
    }
}