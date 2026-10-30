public class Vehicle
{
    protected string brand;
    public Vehicle(string b)
    {
        this.brand=b;
    }
    public void DisplayBrand()
    {
    Console.WriteLine(brand);
    }
}
public class Car : Vehicle
{
    protected string model;
    public Car(string brand,string model) : base(brand)
    {
        this.model=model;
    }
    public void DisplayModel()
    {
        Console.WriteLine(model);
    }
}
class Inherit2
{
    static void Main()
    {
        Vehicle v=new Car("SUV","Batman");
        v.DisplayBrand();

    }
}