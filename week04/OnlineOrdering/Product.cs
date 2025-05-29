using System;

public class Product
{
    private string productName;
    private string productID;
    private double price;
    private int quantity;

    public Product(string productName, string productID, double price, int quantity)
    {
        this.productName = productName;
        this.productID = productID;
        this.price = price;
        this.quantity = quantity;
    }

    public double GetTotalCost()
    {
        return price * quantity;
    }

    public string GetProductInfo()
    {
        return $"{productName} (ID: {productID})";
    }
}