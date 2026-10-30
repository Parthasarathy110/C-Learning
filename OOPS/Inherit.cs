class Employee
{
    protected string name;
    protected int salar;
    public Employee(string name,int sal)
    {
        this.name=name;
        this.salar=sal;
    }
    public void DisplayEmployee()
    {
        Console.WriteLine($"Employee Name: {name}");
        Console.WriteLine($"Salary: {salar}");
    }
}
class Manager:Employee
{
 string Dept;
 public Manager(string name,int sal,string dept):base(name,sal)
    {
        this.Dept=dept;
    }   
    public void Displymanager()
    {
        DisplayEmployee();
        Console.WriteLine($"Department: {Dept}");

    }
}
class Inherit
{
    static void Main(string[] args)
    {
        Manager m=new Manager("Partha",20000,"CSE");
        m.Displymanager();
    }
}