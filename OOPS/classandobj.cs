class Student
{
    string name;
    int age;
    public Student(string name,int age)
    {
        this.name=name;
        this.age=age;
    }
    public void Printing()
    {
        Console.WriteLine(name);
        Console.WriteLine(age);
    }
}
class Child
{
    static void Main(string[] args)
    {
        Student s=new Student("Partha",21);
        s.Printing();
        Student s1=new Student("Vikash",20);
        s1.Printing();
    }
}