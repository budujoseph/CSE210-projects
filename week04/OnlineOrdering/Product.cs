using System;

public class Product
{
    private string _productName;
    private string _productID;
    private double _price;
    private int _quantity;

    public Product(string productName, string productID, double price, int quantity)
    {
        this._productName = productName;
        this._productID = productID;
        this._price = price;
        this._quantity = quantity;
    }

    public double GetTotalCost()
    {
        return _price * _quantity;
    }

    public string GetProductInfo()
    {
        return $"{_productName} (ID: {_productID})";
    }
}