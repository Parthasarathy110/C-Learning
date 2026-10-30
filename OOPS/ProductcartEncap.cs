using System;
class Product
{
    public string ProductName;
    public Product(string name)
    {
        this.ProductName=name;
    }
    private double price;
    private int quantity;
    public void Setprice(double price)
    {
        if (price > 0)
        {
            this.price=price;
        }
        else
        {
            Console.WriteLine("Price should be greater than 0");
        }
    }
    public double Getprice()
    {
        return price;
    }
    public void Setquantity(int quantity)
    {
        if(quantity>0)
        {
            this.quantity=quantity;
        }
        else
        {
          Console.WriteLine("Quantity should be greater than 0");
        }
    }
    public int Getquantity()
    {
        return quantity;
    }
    public void Calculatetotal()
    {
        Console.WriteLine($"Total Price: {price*quantity}");
    }

}
class ProductcartEncap
{
static void Main(string[] args)
    {
        Product p = new Product("Laptop");
        p.Setprice(4000);
        p.Setquantity(-2);
        p.Calculatetotal();
    }
} 