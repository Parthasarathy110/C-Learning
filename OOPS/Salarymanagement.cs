interface ISalary
{
    public abstract int CalculateSalary();
    public abstract void Displaydetails();
}
class FullTimeEmployee : ISalary
{
    public string name;
    public int salary;
    public FullTimeEmployee(string n,int sal)
    {
        this.name=n;
        this.salary=sal;
    }
    public int CalculateSalary()
    {
        return salary+5000;
    }
    public void Displaydetails()
    {
        Console.WriteLine($"Full Time Employee Details: ");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Salary: {CalculateSalary()}");
    }
}
class ParttimeEmployee : ISalary
{
    public string name;
    public int workinghours;
    public ParttimeEmployee(string n,int wh)
    {
        this.name=n;
        this.workinghours=wh;
    }
    public int CalculateSalary()
    {
        return workinghours*2;
    }
    public void Displaydetails()
    {
        Console.WriteLine($"Parttime Employee Details: ");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Salary: {CalculateSalary()}");
    }
}
public class Salarymanagement{
        static void Main(string[] args)
{
    ISalary f=new FullTimeEmployee("Vikash",10000);
    ISalary p=new ParttimeEmployee("Thanusu",8500);
    f.Displaydetails();
    p.Displaydetails();
}

    }