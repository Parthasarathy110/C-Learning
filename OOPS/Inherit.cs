class Animal
{
    public void Eat()
    {
        Console.WriteLine("Eating");
    }
}
class Dog:Animal
{
    public void Leg()
    {
        Console.WriteLine("Dog has four legs");
    }
}
class Inherit
{
    static void Main(string[] args)
    {
        Animal a=new Animal();
        a.Eat();

    }
}