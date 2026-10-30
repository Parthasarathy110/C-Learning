int n=int.Parse (Console.ReadLine());
int a=0;
int b=1;
int c=0;
Console.WriteLine(a+" ");
for(int i = 2; i <= n;i++)
{
    Console.WriteLine(b+" ");
    c=a+b;
    a=b;
    b=c;
}
