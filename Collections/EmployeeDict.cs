class EmployeeDict
{
    static void Main(string[] args)
    {
        Dictionary<int,string?> employee=new Dictionary<int, string?>();

        //Adding Elements

        employee.Add(100,"Dhoni");
        employee.Add(101,"Rohit");
        employee.Add(102,"Rohit");
        employee.Add(103,"Jadeja");
        employee[104]="Raina";

        //Printing Dict
        Console.WriteLine("All Employees:");
        foreach(var emp in employee)
        {
            Console.WriteLine(emp.Key+" "+emp.Value);
        }

        // Accessing using index
        Console.WriteLine("Element at the index:");
        Console.WriteLine(employee[100]);
        if(employee.TryGetValue(103,out string? name))
        {
            Console.WriteLine(name);
        }

        //Updating
        employee[102]="Rohit Sharma";
        Console.WriteLine("Updated Employee Dict:");
        foreach(var emp in employee){
            Console.WriteLine(emp.Key+" "+emp.Value);

        }

        //Removing
        Console.WriteLine("Removig Element: ");
        employee.Remove(105);
        foreach(var emp in employee){
            Console.WriteLine(emp.Key+" "+emp.Value);
        }

        //CHecking exist or not
        Console.WriteLine("Employee exist or not: ");
        Console.WriteLine(employee.ContainsKey(105));

        
    }
}