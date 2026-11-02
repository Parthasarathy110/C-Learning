class Employee
{
    public string domain;
    public Employee(string d)
    {
        this.domain=d;
    }
}
class Manager : Employee
{
    public string name;
    public Manager(string dom,string na):base(dom)
    {
        this.name=na;
    }
}
class Intermediate
{
    static void Main(string[] args)
    {
        /*Employee e=new Manager("SET","Partha");
        Console.WriteLine(e is Manager);
        Console.WriteLine(e is Employee);
        Manager m=e as Manager;
        Console.WriteLine(m==null);*/
       /* var age=15;
        //Error age="Partha";
        Console.WriteLine(age);
        dynamic id=10;
        Console.WriteLine(id);
        id="Hvkk3";
        Console.WriteLine(id);*/

        //Nullable Type
       /* int? age=14;
        age=null;
        Console.WriteLine(age);

        double? sal=20.98;
        sal=null;
        Console.WriteLine(sal);*/


        //Default Value
        /*int? emp1_bonus=10000;
        int emp_bonus=bonus??5000;
        Console.WriteLine(emp_bonus);

        double? sal=null;//
        double salary=sal??15000;
        Console.WriteLine(salary);*/

    //Nullable operations
    string? name="ojnhb";
    Console.WriteLine(name?.Length);

    }
}
