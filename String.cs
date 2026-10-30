string str=Console.ReadLine();
string output="";
for(int i = str.Length-1; i >= 0; i--)
{
    output+=str[i];
}
Console.WriteLine(output);