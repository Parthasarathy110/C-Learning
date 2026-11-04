class EmployeeStack
{
    static void Main(string[] args)
    {
        Stack<string> emp=new Stack<string>();
        emp.Push("Login");
        emp.Push("Add Employee");
        emp.Push("Update Salary");
        Console.WriteLine($"Employees actions: {string.Join(" ",emp)}");
        Console.WriteLine($"Top element: {emp.Peek()}");
        emp.Pop();
        Console.WriteLine($"After Removed: {string.Join(" ",emp)}");
        Console.WriteLine($"Final Count: {emp.Count()}");
        
    }
}