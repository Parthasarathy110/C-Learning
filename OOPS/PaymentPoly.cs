class Payment
{
    public string paymentType="General payment";
    public virtual void Processpayment()
    {
        Console.WriteLine("Processing General Payment");
    }
    public static void DisplayCompany()
    {
        Console.WriteLine("Precise Management System");
    }

}
class UPIPayment : Payment
{
    public new string paymentType="UPI Payment";
    public override void Processpayment()
    {
        Console.WriteLine("Processing UPI Payment");
    }
}
class CardPayment : Payment
{
    public new string paymentType="Card payment";
    public override void Processpayment()
    {
        Console.WriteLine("Processing Card Payment");
    }
}
class PaymentPoly
{
    static void Main(string[] args)
    {
        Payment.DisplayCompany();
        Payment p=new UPIPayment();
        p.Processpayment();
    }
}