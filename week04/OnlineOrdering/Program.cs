using System;

class Program
{
    static void Main(string[] args)
    {
       Address address1 = new Address("Sukuntu str","Asamankese","Eastern","GH");
       Address address2 = new Address("Yayo str", "Kumasi", "Asante", "GH");
       Address address3 = new Address("Mington street", "Springs", "Idah0", "US");

       Customer customer1 = new Customer("Okyere Richard", address1);
       Customer customer2 = new Customer("Ernest Larbi", address2);
       Customer customer3 = new Customer("Benson Francis", address3);

       Product product1 = new Product("Sumsung TV","SMTV", 4655.88, 1);
       Product product2 = new Product("Iphone 15","IPM12", 8700.67, 2);
       Product product3 = new Product("Wireless Mouse","WPT14", 346.55, 5);

       Order order1 = new Order(customer1);
       order1.AddProduct(product1);

       Order order2 = new Order(customer2);
       order2.AddProduct(product2);

       Order order3 = new Order(customer3);
       order3.AddProduct(product3);
       order3.AddProduct(product1);

       Console.WriteLine(order1.PackageLabel());
       Console.WriteLine(order1.GetShippingLabel());
       Console.WriteLine("Total Price: $" + order1.GetTotalCost());

       Console.WriteLine();

       Console.WriteLine(order2.PackageLabel());
       Console.WriteLine(order2.GetShippingLabel());
       Console.WriteLine("Total Price $" + order2.GetTotalCost());

       Console.WriteLine();

       Console.WriteLine(order3.PackageLabel());
       Console.WriteLine(order3.GetShippingLabel());
       Console.WriteLine("Total Price $" + order3.GetTotalCost());


    }
}