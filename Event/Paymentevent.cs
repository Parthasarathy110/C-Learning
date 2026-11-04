

class Payment
{
    public event Action<string> PaymentCompleted;
    public void Proceespayment(string id)
    {
        Console.WriteLine("Processig payment...");
        PaymentCompleted?.Invoke(id);
    }
}
class Paymentevent
{
     public static void SendSMS(string id)
    {
        Console.WriteLine($"SMS Sent: {id}");
    }

     public static void SendEmail(string id)
    {
        Console.WriteLine($"Email Send: {id}");
    }

    static void Main(string[] args)
    {
    Payment p=new Payment();

    p.PaymentCompleted+=SendSMS;
    p.PaymentCompleted+=SendEmail;
    p.Proceespayment("Pay101");
    }
}