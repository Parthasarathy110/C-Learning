using System;
using System.Collections.Generic;
class EmployeeList
{
    static void Main(string[] args)
    {
        List<int?> employee=new List<int?>();
        //Adding Elements
        employee.Add(100);
        employee.AddRange(new int?[] {101,102,103,104,105,106,107,108,109,110});
       
       //Displays
       /* foreach(int i in employee){
            Console.WriteLine(i);
        }*/
        /*for(int i=0;i<employee.Count;i++){
            Console.WriteLine($"Element{i+1}: {employee[i]}");
        }*/
        //Console.WriteLine(string.Join(" ",employee));
        //employee.ForEach(e=>Console.WriteLine(e));

        //Insert
       /*employee.Insert(2,115);
       Console.WriteLine(string.Join(" ",employee));*/

       //Update
      /*employee[2]=null;
       Console.WriteLine(string.Join(" ",employee));*/

       //Remove
       /*Console.WriteLine(string.Join(" ",employee));
       employee.Remove(100);
       Console.WriteLine(string.Join(" ",employee));
       employee.RemoveAt(4);
       Console.WriteLine(string.Join(" ",employee));*/

       //Indexfinding
       /*Console.WriteLine(employee.IndexOf(110));*/

       //Exist
      /* Console.WriteLine(employee.Contains(100));
       Console.WriteLine(employee.Exists(x=>x==109));*/

       //Sorting
       /*employee.Sort();
       Console.WriteLine(string.Join(" ",employee));*/

       //Reverse
      /* employee.Reverse();
       Console.WriteLine(string.Join(" ",employee));*/

       //Total Count
      /* Console.WriteLine(employee.Count());*/

      //Converting List to Array
      /*int?[] arr=employee.ToArray();
      foreach(int? i in arr){
        Console.WriteLine(i);
      }*/

      //Converting Array to list
      int?[] arr={1,2,3,4};
      List<int?> employee2=arr.ToList();
      Console.WriteLine(string.Join(" ",employee2));
    }
}