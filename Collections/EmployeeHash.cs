class EmployeeHash
{
    static void Main(string[] args)
    {
        HashSet<int> set=new HashSet<int>();
        set.Add(10);
        set.Add(20);
        set.Add(30);
        set.Add(20);
        set.Add(40);
        set.Add(50);
        set.Add(30);
       /* foreach(int i in set)
        {
            Console.WriteLine(i+" ");
        }*/
        Console.WriteLine(string.Join(" ",set));
        Console.WriteLine($"Total number of elements: {set.Count}");
        Console.WriteLine($"This number is exist or not: {set.Contains(50)}");
        set.Remove(10);
        Console.WriteLine(string.Join(" ",set));
        Console.WriteLine($"Final Count: {set.Count}");
    }
}