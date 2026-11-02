class Employee
{
    public string name;
    public int salary;
    public Employee(string n,int sal)
    {
        this.name=n;
        this.salary=sal;
    }
}
class Manager : Employee
{
    public int teamSize;
    public Manager(int ts,string name,int sal):base(name,sal)
    {
        this.teamSize=ts;
    }
}
class EmployeemanagementIntermediate
{
    static void Main(string[] args)
    {
        Employee e=new Manager(5,"Raj",10000);
        Console.WriteLine(e is Manager);
        Console.WriteLine(e is Employee);
        Manager m=e as Manager;
        Console.WriteLine(m==null);
    }
}