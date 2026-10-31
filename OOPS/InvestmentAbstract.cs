abstract class Investment
{
    public string customername;
    public abstract void CalculateReturns();
    public void DisplayCustomer()
    {
        Console.WriteLine($"Customer Name: {customername}");
    }
}
class GoldInvestment : Investment
{
    public override void CalculateReturns()
    {
        Console.WriteLine("Gold investment returns calculated.");
    }
}
class SilverInvestment : Investment
{
    public override void CalculateReturns()
    {
       Console.WriteLine("Silver investment calculated.");
    }
}
class InvestmentAbstract
{
    static void Main(string[] args)
    {
        Investment g=new GoldInvestment();
        Investment s=new SilverInvestment();
        g.customername="Arun";
        Console.WriteLine($"Customer Name: {g.customername}");
        g.CalculateReturns();
        s.customername="kumar";
        Console.WriteLine($"Customer Name: {s.customername}");
        s.CalculateReturns();
    }
}