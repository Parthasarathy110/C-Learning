class Person
{
    private string name;
    public Person(string name)
    {
        this.name=name;
    }
    public void DisplayName()
    {
        Console.WriteLine($"Name: {name}");
    }
}
class Student : Person
{
    private int rollno;
    public Student(int roll,string name):base(name){
        this.rollno=roll;
    }
    public void DisplayRollno(){
        Console.WriteLine($"Roll no: {rollno}");
    }
}
class Exam:Student{
    private int marks;
    public Exam(int mark,string name,int roll):base(roll,name){
        this.marks=mark;
    }
    public void Displaymarks()
    {
        Console.WriteLine($"Marks: {marks}");
    }
}
class ExamInherit{
    static void Main(string[] args){
        Exam e=new Exam(76,"Partha",110);
        e.DisplayRollno();
        e.DisplayName();
        e.Displaymarks();
        
    }
}