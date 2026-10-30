Console.WriteLine("Enter the Array size: ");
int n=int.Parse(Console.ReadLine());
int[] arr = new int[n];
for(int i = 0; i < n; i++)
{
    Console.WriteLine($"Enter the element{i+1}: ");
    arr[i]=int.Parse(Console.ReadLine());
}
int sum=0;
foreach(int num in arr)
{
    sum+=num;
}
Console.Write(sum);
