using System;
class Bank
{
    private double balance=0;
    public void Deposit(double dep)
    {
        if (dep > 0)
        {
            balance+=dep;
        }
    }
    public void Display()
    {
        Console.WriteLine(balance);
    }

}
class Account
{
    static void Main(string[] args)
    {
        Bank b=new Bank();
        b.Deposit(1000.0);
       
    }
}